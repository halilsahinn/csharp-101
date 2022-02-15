using System;

namespace _20_Sinif_Kavrami_Soz_Dizimi_Field_Metot_Tanimlama_Erisim_Belirliyiciler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Söz Dizimi
            //class  SinifAdi{
            //[Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //[Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi(parametre Listesi);
            //}

            //Erişim Belirleyiciler
            //*Public
            //Private
            //Internal
            //Protected
            Calisan calisan1 = new Calisan("Halil","ŞAHİN", 1323232, "Bilgi İşlem");
            calisan1.CalisanBilgileriGetir();
            Console.WriteLine("***************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ali";
            calisan2.SoyAd = "Şahin";
            calisan2.No = 12344;
            calisan2.Departman = "Yazılım";
            calisan2.CalisanBilgileriGetir();
            Console.WriteLine("***************");

            Calisan calisan3 = new Calisan("Halil", "ŞAHİN", 1323232, "Bilgi İşlem");
            calisan3.Ad = "Oğuzhan";
            calisan3.SoyAd = "ŞAHİN";
            calisan3.No = 1323232;
            calisan3.Departman = "Muhasebe";
            calisan3.CalisanBilgileriGetir();
            Console.WriteLine("***************");

            Console.ReadLine();
        }
    }

    class Calisan
    {


        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public Calisan()
        {
             
        }
     
        public Calisan(string ad, string soyAd, int no, string departman)
        {
            Ad = ad;
            SoyAd = soyAd;
            No = no;
            Departman = departman;
        }

        public void CalisanBilgileriGetir()
        {

            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soy Adı:{0}", SoyAd);
            Console.WriteLine("Çalışan No:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);


        }

    }


}
