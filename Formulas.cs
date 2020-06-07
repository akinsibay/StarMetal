using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMetal
{
    class Formulas
    {
        public static bool a_aEkle = false;
        public static bool a_suEkle = false;
        public static bool c_cEkle = false;
        public static bool c_suEkle = false;

        public static double aBanyoKimyasal(double aAlt,double aUst, int banyoHacim)
        {
            return ((aAlt + aUst) / 2) * banyoHacim;
        }
        public static double aKonsantrasyon(double aBanyo)
        {
            return 0.587 * aBanyo;
        }
        public static int kaplamaSuresi(double kapKal,int kapHiz)
        {
            return Convert.ToInt32((kapKal / kapHiz) * 60);
        }
        public static double aKaplamaMiktar(double topAlan,double kapKal)
        {
            return (topAlan * (kapKal / 100000) * 8.1) * 1000;
        }
        public static double aEklenen(double aLitre,double aKaplamaMiktarLabel)
        {
            return aLitre * aKaplamaMiktarLabel;
        }
        public static double aPeristaltik(double aEklenenLabel,double kaplamaSuresiLabel)
        {
            return aEklenenLabel / kaplamaSuresiLabel;
        }

        public static double cKonsantrasyon(double cBanyo)
        {
            return 1.055 * (50 - cBanyo);
        }

        public static double cEklenen(double aEklenenLabel,double aOverC)
        {
            return aEklenenLabel * aOverC;
        }
        public static double cPeristaltik(double cEklenenLabel,double kaplamaSuresiLabel)
        {
            return cEklenenLabel / kaplamaSuresiLabel;
        }
        public static double borKaplamaMiktar(double bAlt,double bUst,int banyoHacim,double bLitre)
        {
            return ((0.8) * ((bAlt + bUst) / 2) * banyoHacim) * (100 / bLitre);
        }
        public static double borBanyoMiktar(double aBanyoMiktarLabel,double borKaplamaMiktarLabel)
        {
            return borKaplamaMiktarLabel / aBanyoMiktarLabel;
        }
        public static double borKonsantrasyon(double borKaplamaMiktarLabel,int banyoHacim)
        {
            return borKaplamaMiktarLabel / banyoHacim;
        }
        public static double borEklenen(double aKaplamaMiktarLabel,double borBanyoMiktarLabel)
        {
            return aKaplamaMiktarLabel * borBanyoMiktarLabel;
        }
        public static double borPeristaltik(double borEklenenLabel,double kaplamaSuresiLabel)
        {
            return borEklenenLabel / kaplamaSuresiLabel;
        }
        public static double cDegerDuzeltme(double cKonsantrasyonLabel,double cAlt,double cUst,double cLitre,int banyoHacim)
        {
            if (cKonsantrasyonLabel < cAlt)
            {
                c_cEkleme();
                return (((cAlt + cUst) / 2) - cKonsantrasyonLabel) * banyoHacim / cLitre;
                //DEĞERİN YANINA SU EKLE EKLENECEK
            }
            else if(cKonsantrasyonLabel > cUst)
            {
                c_suEkleme();
                return ((cKonsantrasyonLabel * banyoHacim) / ((cAlt + cUst) / 2)) - banyoHacim;
                //DEĞERİN YANINA C EKLE EKLENECEK
            }
            else
            {
                return 0;
                //BANYO NORMAL YAZACAK
            }
        }
        public static double aDegerDuzeltme(double aKonsantrasyonLabel, double aAlt, double aUst, double aLitre, int banyoHacim)
        {
            if (aKonsantrasyonLabel < aAlt)
            {
                a_aEkleme(); //A EKLE YAZ
                return (((aAlt + aUst) / 2) - aKonsantrasyonLabel) * banyoHacim / aLitre;
            }
            else if (aKonsantrasyonLabel > aUst)
            {
                a_suEkleme(); //SU EKLE YAZ
                return ((aKonsantrasyonLabel * banyoHacim) / ((aAlt + aUst) / 2)) - banyoHacim;
            }
            else
            {
                //BANYO NORMAL YAZACAK
                return 0;
                
            }
        }
        public static void a_aEkleme()
        {
            a_aEkle = true;
            a_suEkle = false;
            //suEkle = false;
        }
        public static void a_suEkleme()
        {
            a_suEkle = true;
            a_aEkle = false;
            //aEkle = false;
            //cEkle = false;
        }
        public static void c_cEkleme()
        {
            c_cEkle = true;
            c_suEkle = false;
            //aEkle = false;
            //suEkle = false;
        }
        public static void c_suEkleme()
        {
            c_suEkle = true;
            c_cEkle = false;
            //aEkle = false;
            //cEkle = false;
        }


        public static long aStepSayisi(double aPeristaltik,int kaplamaSuresi,double ka,int oneRev)
        {
            return Convert.ToInt64(aPeristaltik * kaplamaSuresi*ka*oneRev);
        }
        public static double aHiz(double aPeristaltik,double ka,int oneRev)
        {
            return aPeristaltik * ((oneRev * ka) / 60);
        }
        public static long bStepSayisi(double bPeristaltik, int kaplamaSuresi, double kb, int oneRev)
        {
            return Convert.ToInt64(bPeristaltik * kaplamaSuresi * kb * oneRev);
        }
        public static double bHiz(double bPeristaltik, double kb, int oneRev)
        {
            return bPeristaltik * ((oneRev * kb) / 60);
        }
        public static long cStepSayisi(double cPeristaltik, int kaplamaSuresi, double kc, int oneRev)
        {
            return Convert.ToInt64(cPeristaltik * kaplamaSuresi * kc * oneRev);
        }
        public static double cHiz(double cPeristaltik, double kc, int oneRev)
        {
            return cPeristaltik * ((oneRev * kc) / 60);
        }
        public static long suStepSayisi(double suPeristaltik, int kaplamaSuresi, double ksu, int oneRev)
        {
            return Convert.ToInt64(suPeristaltik * kaplamaSuresi * ksu * oneRev);
        }
        public static double suHiz(double suPeristaltik, double ksu, int oneRev)
        {
            return suPeristaltik * ((oneRev * ksu) / 60);
        }
        public static long amStepSayisi(double amPeristaltik, int kaplamaSuresi, double kam, int oneRev)
        {
            return Convert.ToInt64(amPeristaltik * kaplamaSuresi * kam * oneRev);
        }
        public static double amHiz(double amPeristaltik, double kam, int oneRev)
        {
            return amPeristaltik * ((oneRev * kam) / 60);
        }

    }
}
