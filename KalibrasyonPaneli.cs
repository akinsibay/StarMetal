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
using Newtonsoft.Json;
namespace StarMetal
{
    public partial class KalibrasyonPaneli : Form
    {
        public bool cOtomatik = false;
        public bool aOtomatik = false;      
     
        string kalibFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\KalibrasyonData.json";
        string setupFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\SetupData.json";
        string seciliMalzemeFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\SeciliMalzeme.json";
        string formulOutputFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\")) + @"DataFiles\FormulOutput.json";
        
        int kapHizx, banyoHacimx;
        double aOverCx, aAltx, aUstx, aLitrex, aBanyox, cAltx, cUstx, cLitrex, cBanyox, bAltx, bUstx, bLitrex, topAlanx, kapKalx;
        public KalibrasyonPaneli()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                aOlculenBanyoLbl.Visible = false;
                aBanyo.Visible = false;
                aOtomatik = true;
                GostergePaneli gostergePaneli = new GostergePaneli();
                gostergePaneli.aOtoDurum.Visible = true;
            }
            else
            {
                aOlculenBanyoLbl.Visible = true;
                aBanyo.Visible = true;
                aOtomatik = false;
                GostergePaneli gostergePaneli = new GostergePaneli();
                gostergePaneli.aOtoDurum.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                cBanyoLbl.Visible = false;
                cBanyo.Visible = false;
                cOtomatik = true;
            }
            else
            {
                cBanyoLbl.Visible = true;
                cBanyo.Visible = true;
                cOtomatik = false;
            }
        }

       

        private void KalibrasyonPaneli_Load(object sender, EventArgs e)
        {
            ExceptionManagement.HandleException(() =>
            {
                dynamic data = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(kalibFile));
                aOverc.Text = data["aOverC"].ToString();
                kapHiz.Text = data["kapHiz"].ToString();
                banyoHacim.Text = data["banyoHacim"].ToString();
                aAlt.Text = data["aAlt"].ToString();
                aUst.Text = data["aUst"].ToString();
                aLitre.Text = data["aLitre"].ToString();
                aBanyo.Text = data["aBanyo"].ToString();
                cAlt.Text = data["cAlt"].ToString();
                cUst.Text = data["cUst"].ToString();
                cLitre.Text = data["cLitre"].ToString();
                cBanyo.Text = data["cBanyo"].ToString();
                bAlt.Text = data["bAlt"].ToString();
                bUst.Text = data["bUst"].ToString();
                bLitre.Text = data["bLitre"].ToString();
                oneRev.Text = data["oneRev"].ToString();
                ka.Text = data["ka"].ToString();
                kb.Text = data["kb"].ToString();
                kc.Text = data["kc"].ToString();
                ksu.Text = data["ksu"].ToString();
                kam.Text = data["kam"].ToString();
                suDebisi.Text = data["suDebisi"].ToString();
            });           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {                     
            ExceptionManagement.HandleException(() =>
            {
                DataObj dataObj = new DataObj
                {
                    aOverC = Convert.ToDouble(aOverc.Text),
                    kapHiz = Convert.ToInt32(kapHiz.Text),
                    banyoHacim = Convert.ToInt32(banyoHacim.Text),
                    aAlt = Convert.ToDouble(aAlt.Text),
                    aUst = Convert.ToDouble(aUst.Text),
                    aLitre = Convert.ToDouble(aLitre.Text),
                    aBanyo = Convert.ToDouble(aBanyo.Text),
                    cAlt = Convert.ToDouble(cAlt.Text),
                    cUst = Convert.ToDouble(cUst.Text),
                    cLitre = Convert.ToDouble(cLitre.Text),
                    cBanyo = Convert.ToDouble(cBanyo.Text),
                    bAlt = Convert.ToDouble(bAlt.Text),
                    bUst = Convert.ToDouble(bUst.Text),
                    bLitre = Convert.ToDouble(bLitre.Text),
                    oneRev = Convert.ToInt32(oneRev.Text),
                    ka = Convert.ToDouble(ka.Text),
                    kb = Convert.ToDouble(kb.Text),
                    kc = Convert.ToDouble(kc.Text),
                    ksu = Convert.ToDouble(ksu.Text),
                    kam = Convert.ToDouble(kam.Text),
                    suDebisi = Convert.ToDouble(suDebisi.Text)
                };
                string json = JsonConvert.SerializeObject(dataObj);
                File.WriteAllText(kalibFile, json);
                MessageBox.Show("Değerler başarıyla kaydedildi.");
                ////KALİBRASYON PARAMETRELERİNİ OKU
                dynamic data = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(kalibFile));
                aOverCx = data["aOverC"];
                kapHizx = data["kapHiz"];
                banyoHacimx = data["banyoHacim"];
                aAltx = data["aAlt"];
                aUstx = data["aUst"];
                aLitrex = data["aLitre"];
                aBanyox = data["aBanyo"];
                cAltx = data["cAlt"];
                cUstx = data["cUst"];
                cLitrex = data["cLitre"];
                cBanyox = data["cBanyo"];
                bAltx = data["bAlt"];
                bUstx = data["bUst"];
                bLitrex = data["bLitre"];
                ////SETUP PARAMETRELERİNİ OKU
                dynamic seciliMalzeme = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(seciliMalzemeFile));
                string setupParameter = seciliMalzeme["malzemeAdi"];
                dynamic setData = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(setupFile));
                topAlanx = setData[$"{setupParameter}"]["topAlan"];
                kapKalx = setData[$"{setupParameter}"]["kapKal"];
                ////FORMÜLLER
                double aBanyoMiktar = Formulas.aBanyoKimyasal(aAltx, aUstx, banyoHacimx);
                double aKonsantrasyon = Formulas.aKonsantrasyon(aBanyox);
                int kaplamaSuresi = Formulas.kaplamaSuresi(kapKalx, kapHizx);
                double aKaplamaMiktar = Formulas.aKaplamaMiktar(topAlanx, kapKalx);
                double aEklenen = Formulas.aEklenen(aLitrex, aKaplamaMiktar);
                double aPeristaltik = Formulas.aPeristaltik(aEklenen, kaplamaSuresi);
                double cKonsantrasyon = Formulas.cKonsantrasyon(cBanyox);
                double cEklenen = Formulas.cEklenen(aEklenen, aOverCx);
                double cPeristaltik = Formulas.cPeristaltik(cEklenen, kaplamaSuresi);
                double borKaplamaMiktar = Formulas.borKaplamaMiktar(bAltx, bUstx, banyoHacimx, bLitrex);
                double borBanyoMiktar = Formulas.borBanyoMiktar(aBanyoMiktar, borKaplamaMiktar);
                double borKonsantrasyon = Formulas.borKonsantrasyon(borKaplamaMiktar, banyoHacimx);
                double borEklenen = Formulas.borEklenen(aKaplamaMiktar, borBanyoMiktar);
                double borPeristaltik = Formulas.borPeristaltik(borEklenen, kaplamaSuresi);
                double cDegerDuzeltme = Formulas.cDegerDuzeltme(cKonsantrasyon, cAltx, cUstx, cLitrex, banyoHacimx);
                double aDegerDuzeltme = Formulas.aDegerDuzeltme(aKonsantrasyon, aAltx, aUstx, aLitrex, banyoHacimx);

                ////FORMÜL SONUÇLARININ DOSYAYA YAZIMI
                FormulOutput formul = new FormulOutput
                {
                    aBanyoKimyasal = aBanyoMiktar,
                    aKonsantrasyon = aKonsantrasyon,
                    kaplamaSuresi = kaplamaSuresi,
                    aKaplamaMiktar = aKaplamaMiktar,
                    aEklenen = aEklenen,
                    aPeristaltik = aPeristaltik,
                    cKonsantrasyon = cKonsantrasyon,
                    cEklenen = cEklenen,
                    cPeristaltik = cPeristaltik,
                    borKaplamaMiktar = borKaplamaMiktar,
                    borBanyoMiktar = borBanyoMiktar,
                    borKonsantrasyon = borKonsantrasyon,
                    borEklenen = borEklenen,
                    borPeristaltik = borPeristaltik,
                    cDegerDuzeltme = cDegerDuzeltme,
                    aDegerDuzeltme = aDegerDuzeltme
                };
                string test = JsonConvert.SerializeObject(formul);
                File.WriteAllText(formulOutputFile, test);
            });
            
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            GostergePaneli gosterge = new GostergePaneli();
            string aText = gosterge.aDegerDuzeltmeLbl.Text;
            string cText = gosterge.cDegerDuzeltmeLbl.Text;
            double aBanyoDeger = Convert.ToDouble(aBanyo.Text);
            double cBanyoDeger = Convert.ToDouble(cBanyo.Text);
            if(aBanyoDeger == 0 && cBanyoDeger == 0)
            {
                //HİÇBİR ŞEY OLMADAN ÇIK
            }
            else if(aBanyoDeger == 0 && cBanyoDeger > 0 && cText == "BANYO NORMAL")
            {
                //label19.Text = "BURDAYIM";
            }
        }
    }
    class DataObj
    {
        public double aOverC { get; set; }
        public int kapHiz { get; set; }
        public int banyoHacim { get; set; }
        public double aAlt { get; set; }
        public double aUst { get; set; }
        public double aLitre { get; set; }
        public double aBanyo { get; set; }
        public double cAlt { get; set; }
        public double cUst { get; set; }
        public double cLitre { get; set; }
        public double cBanyo { get; set; }
        public double bAlt { get; set; }
        public double bUst { get; set; }
        public double bLitre { get; set; }
        public int oneRev { get; set; }
        public double ka { get; set; }
        public double kb { get; set; }
        public double kc { get; set; }
        public double ksu { get; set; }
        public double kam { get; set; }
        public double suDebisi { get; set; }
    }

    class FormulOutput
    {
        public double aBanyoKimyasal { get; set; }
        public double aKonsantrasyon { get; set; }
        public int kaplamaSuresi { get; set; }
        public double aKaplamaMiktar { get; set; }
        public double aEklenen { get; set; }
        public double aPeristaltik { get; set; }
        public double cKonsantrasyon { get; set; }
        public double cEklenen { get; set; }
        public double cPeristaltik { get; set; }
        public double borKaplamaMiktar { get; set; }
        public double borBanyoMiktar { get; set; }
        public double borKonsantrasyon { get; set; }
        public double borEklenen { get; set; }
        public double borPeristaltik { get; set; }
        public double cDegerDuzeltme { get; set; }
        public double aDegerDuzeltme { get; set; }

    }
}
