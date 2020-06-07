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
    public partial class GostergePaneli : Form
    { //testt
        string kalibFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\KalibrasyonData.json";
        string setupFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\SetupData.json";
        string seciliMalzemeFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\SeciliMalzeme.json";
        string formulOutputFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\"))+ @"DataFiles\FormulOutput.json";
        public GostergePaneli()
        {
            InitializeComponent();          
        }

        private void GostergePaneli_Load(object sender, EventArgs e)
        {
            ExceptionManagement.HandleException(() =>
            {
                dynamic data = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(formulOutputFile));
                dynamic kalibData = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(kalibFile));
                ////
                aBanyoMiktar.Text = data["aBanyoKimyasal"].ToString();
                aKonsantrasyon.Text = data["aKonsantrasyon"].ToString();
                kaplamaSuresi.Text = data["kaplamaSuresi"].ToString();
                aKaplamaMiktar.Text = data["aKaplamaMiktar"].ToString();
                aEklenen.Text = data["aEklenen"].ToString();
                aPeristaltik.Text = data["aPeristaltik"].ToString();
                cKonsantrasyon.Text = data["cKonsantrasyon"].ToString();
                cEklenen.Text = data["cEklenen"].ToString();
                cPeristaltik.Text = data["cPeristaltik"].ToString();
                borKaplamaMiktar.Text = data["borKaplamaMiktar"].ToString();
                borBanyoMiktar.Text = data["borBanyoMiktar"].ToString();
                borKonsantrasyon.Text = data["borKonsantrasyon"].ToString();
                borEklenen.Text = data["borEklenen"].ToString();
                borPeristaltik.Text = data["borPeristaltik"].ToString();
                cDegerDuzeltme.Text = data["cDegerDuzeltme"].ToString();
                aDegerDuzeltme.Text = data["aDegerDuzeltme"].ToString();
                suPeristaltik.Text = kalibData["suDebisi"].ToString();

                if (Formulas.a_aEkle == true)
                {
                    aDegerDuzeltmeLbl.Text = "A EKLE";
                }
                if (Formulas.a_suEkle == true)
                {
                    aDegerDuzeltmeLbl.Text = "SU EKLE";
                }
                if (Formulas.c_cEkle == true)
                {
                    cDegerDuzeltmeLbl.Text = "C EKLE";
                }
                if (Formulas.c_suEkle == true)
                {
                    cDegerDuzeltmeLbl.Text = "SU EKLE";
                }
                if (Convert.ToDouble(aDegerDuzeltme.Text) == 0)
                {
                    aDegerDuzeltmeLbl.Text = "BANYO NORMAL";
                }
                if (Convert.ToDouble(cDegerDuzeltme.Text) == 0)
                {
                    cDegerDuzeltmeLbl.Text = "BANYO NORMAL";
                }
            });
        }
    }
}
