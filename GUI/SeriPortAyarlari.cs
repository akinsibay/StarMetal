using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMetal
{
    public partial class SeriPortAyarlari : Form
    {
        string seriSettingsFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\SeriPortSettings.json";
        public SeriPortAyarlari()
        {
            InitializeComponent();
        }

        private void SeriPortAyarları_Load(object sender, EventArgs e)
        {
            
            ExceptionManagement.HandleException(() =>
            {
                string[] portlar = SerialPort.GetPortNames();
                foreach (string port in portlar)
                {
                    serialCombo.Items.Add(port);
                }
                dynamic settings = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(seriSettingsFile));
                serialCombo.SelectedItem = settings["COMPort"].ToString();
            });
        }

        private void serialCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExceptionManagement.HandleException(() =>
            {
                SeriPortSettings seriPort = new SeriPortSettings
                {
                    COMPort = serialCombo.SelectedItem.ToString()
                };
                string json = JsonConvert.SerializeObject(seriPort);
                File.WriteAllText(seriSettingsFile, json);
            });
        }

        private void uygulaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayarların geçerli olması için program kapatılacak. Yeniden çalıştırınız.");
            Application.Exit();
        }
    }


    class SeriPortSettings
    {
        public string COMPort { get; set; }
    }
}
