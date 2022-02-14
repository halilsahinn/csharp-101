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
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Halil";
            calisan1.SoyAd = "ŞAHİN";
            calisan1.No = 1323232;
            calisan1.Departman = "Bilgi İşlem";
            calisan1.CalisanBilgileriGetir();
            Console.WriteLine("***************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ali";
            calisan2.SoyAd = "Şahin";
            calisan2.No = 12344;
            calisan2.Departman = "Yazılım";
            calisan2.CalisanBilgileriGetir();
            Console.ReadLine();
        }
    }

    class Calisan
    {


        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public void CalisanBilgileriGetir()
        {

            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soy Adı:{0}", SoyAd);
            Console.WriteLine("Çalışan No:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);


        }

    }


}
