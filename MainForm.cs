using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
namespace StarMetal
{
    
    public partial class MainForm : Form
    {
        ModbusClient modbusClient;
        public int[] _holdings;
        
        string formulOutputFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\FormulOutput.json";
        string kalibFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\KalibrasyonData.json";
        string seriSettingsFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\SeriPortSettings.json";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dynamic settings = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(seriSettingsFile));
            string portInfo = settings["COMPort"].ToString();
            portInfoLbl.Text = portInfo;
            arduino.PortName = portInfo;
            
            modbusClient = new ModbusClient("192.168.6.6", 502);
            try
            {
                modbusClient.Connect();
            }
            catch (Exception)
            {
                //MessageBox.Show("Wise ile bağlantı kurulamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void motorBaslatBtn_Click(object sender, EventArgs e)
        {
            ExceptionManagement.HandleException(() =>
            {
                motorStatusLbl.Visible = true;
                dynamic formulData = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(formulOutputFile));
                dynamic kalibData = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(kalibFile));
                double aPeristaltik = formulData["aPeristaltik"];
                double borPeristaltik = formulData["borPeristaltik"];
                double cPeristaltik = formulData["cPeristaltik"];
                double suPeristaltik = kalibData["suDebisi"];
                int kaplamaSuresi = formulData["kaplamaSuresi"];
                double ka = kalibData["ka"];
                double kb = kalibData["kb"];
                double kc = kalibData["kc"];
                double ksu = kalibData["ksu"];
                int oneRev = kalibData["oneRev"];
                
                long aStepSayisi = Formulas.aStepSayisi(aPeristaltik, kaplamaSuresi, ka, oneRev);
                double aHiz = Formulas.aHiz(aPeristaltik, ka, oneRev);

                long bStepSayisi = Formulas.bStepSayisi(borPeristaltik, kaplamaSuresi, kb, oneRev);
                double bHiz = Formulas.bHiz(borPeristaltik, kb, oneRev);

                long cStepSayisi = Formulas.cStepSayisi(cPeristaltik, kaplamaSuresi, kc, oneRev);
                double cHiz = Formulas.cHiz(cPeristaltik, kc, oneRev);

                long suStepSayisi = Formulas.suStepSayisi(suPeristaltik, kaplamaSuresi, ksu, oneRev);
                double suHiz = Formulas.suHiz(suPeristaltik, ksu, oneRev);

                //arduino.Write(aStepSayisi.ToString());
                //arduino.Write(aHiz.ToString());
                //arduino.Write(bStepSayisi.ToString());
                //arduino.Write(bHiz.ToString());
                if (!arduino.IsOpen)
                {
                    string deger = (Math.Round(aHiz, 1).ToString().Replace(',','.') + "*" + aStepSayisi.ToString() + "*" + Math.Round(bHiz,1).ToString().Replace(',', '.') + "*" + bStepSayisi.ToString() + "*" + Math.Round(cHiz, 1).ToString().Replace(',', '.') + "*"+ cStepSayisi.ToString() + "*"+ Math.Round(suHiz, 1).ToString().Replace(',', '.') + "*" + suStepSayisi.ToString()+"*40.0*8000").ToString();
                    arduino.Open();
                    //arduino.Write(aHiz.ToString());
                    //arduino.Write("400,0*800,0*800,0*1600,0*400,0*800,0*800,0*8000,0*400,0*800,0");
                    //arduino.Write("400,0*114696*800,0*1600*400,0*800*800,0*8000*400,0*800");
                    //arduino.Write("2000,0*100000000*100,0*200000000*42,5*100000000*800,0*-20000*800,0*100000001");
                    //arduino.Write(deger);
                    //arduino.Write("21.2*57348*6*16470*21.2*57348*0.6*27000*400.0*800");
                    arduino.Write("42.2*57348*6.1*16475*21.2*57348*10.0*27000*80.0*8000");
                    Thread.Sleep(10);
                    //string arduinodanGelen = arduino.ReadLine();
                    //label1.Text = arduinodanGelen;
                    //listBox1.Items.Add(arduinodanGelen);
                    motorStatusLbl.Text = "BAĞLANTI KURULDU";
                    motorStatusLbl.ForeColor = Color.Green;
                }
            });
                                
        }

        private void motorDurdurBtn_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Write("STOP*STOP*STOP*STOP*STOP*STOP*STOP*STOP*STOP*STOP*STOP*STOP");
                Thread.Sleep(2000);
                arduino.Close();
                motorStatusLbl.Text = "BAĞLANTI KAPATILDI";
                motorStatusLbl.ForeColor = Color.Red;
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı zaten kapalı");
            }
            
        }

        private void göstergePaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GostergePaneli gostergePaneli = new GostergePaneli();
            gostergePaneli.Show();
        }

        private void değerGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupDegerleri setup = new SetupDegerleri();
            setup.Show();
        }

        private void seriPortAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeriPortAyarlari seriPort = new SeriPortAyarlari();
            seriPort.Show();
        }

        private void manuelSürmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManuelSürme manuelSürme = new ManuelSürme();
            manuelSürme.Show();
        }

        private void modbusTimer_Tick(object sender, EventArgs e)
        {
            if (modbusClient.Connected == true)
            {       
                _holdings = modbusClient.ReadHoldingRegisters(0, 4);
                double aiDeger = _holdings[3];
                double ph = (aiDeger * 14) / 4095;
                phLbl.Text = "PH: " + Math.Round(ph,1).ToString();
                //modbusClient.Disconnect();
            }

        }
    }
}
