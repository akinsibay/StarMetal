using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMetal
{
    public partial class SetupDegerleri : Form
    {
        public string malzeme;
        string setupFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\SetupData.json";
        string malzemeListesi = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\MalzemeListesi.json";
        string seciliMalzeme = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\SeciliMalzeme.json";

        public SetupDegerleri()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            topAlan.Text = "";
            kapKal.Text = "";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ExceptionManagement.HandleException(() =>
            {
                malzeme = comboBox1.Text.ToLower();
                dynamic setData = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(setupFile));
                topAlan.Text = setData[$"{malzeme}"]["topAlan"];
                kapKal.Text = setData[$"{malzeme}"]["kapKal"];
            });           
        }

        private void goKalibrasyonBtn_Click(object sender, EventArgs e)
        {
            ExceptionManagement.HandleException(() =>
            {
                if (malzeme == null)
                {
                    MessageBox.Show("Malzeme seçmeden kalibrasyon sayfasına gidemezsiniz!");
                }
                else
                {
                    MalzemeSecimi malzemeSecimi = new MalzemeSecimi
                    {
                        malzemeAdi = malzeme
                    };

                    string value = JsonConvert.SerializeObject(malzemeSecimi);
                    File.WriteAllText(seciliMalzeme, value);

                    KalibrasyonPaneli kalibrasyon = new KalibrasyonPaneli();
                    kalibrasyon.Show();
                }
            });                     
        }

        private void yeniSetupBtn_Click(object sender, EventArgs e)
        {
            YeniSetup yeniSetup = new YeniSetup();
            yeniSetup.Show();
        }
    }
    class MalzemeSecimi
    {
        public string malzemeAdi { get; set; }
    }
}
