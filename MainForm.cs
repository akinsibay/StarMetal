using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMetal
{
    public partial class MainForm : Form
    {
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
        }

        private void motorBaslatBtn_Click(object sender, EventArgs e)
        {
            ExceptionManagement.HandleException(() =>
            {
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
                    arduino.Open();
                    arduino.Write(aHiz.ToString());
                    Thread.Sleep(700);
                    string arduinodanGelen = arduino.ReadLine();
                    label1.Text = arduinodanGelen;
                    listBox1.Items.Add(arduinodanGelen);
                    motorStatusLbl.Text = "MOTOR ÇALIŞIYOR";
                    motorStatusLbl.ForeColor = Color.Green;
                }
            });
                                
        }     

        private void serialCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            arduino.PortName = serialCombo.SelectedItem.ToString();         
        }
      

        private void motorDurdurBtn_Click(object sender, EventArgs e)
        {
            arduino.Close();
            motorStatusLbl.Text = "MOTOR DURUYOR";
            motorStatusLbl.ForeColor = Color.Red;
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
    }
}
