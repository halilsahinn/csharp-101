using System;
namespace _22_Static_Sinif_Ve_Uyeler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe","Yılmaz","IK");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz", "Yılmaz", "IK");
            Calisan calisan2 = new Calisan("zikriye", "Yılmaz", "IK");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("***************");

            Console.WriteLine("Toplama İşlemi Sonucu:{0}",Islemler.topla(200,300));
            Console.WriteLine("Çıkarma İşlemi Sonucu:{0}", Islemler.Cikar(200,100));

            Console.ReadLine();

        }

    }


    class Calisan
    {

        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }
        
        private string Isim;
        private string SoyIsim;
        private string Departman;

        static Calisan()
        {

            calisanSayisi = 0;
        }

        public Calisan(string ısim, string soyIsim, string departman)
        {
            Isim = ısim;
            SoyIsim = soyIsim;
            Departman = departman;
            calisanSayisi++;
        }

         


    }

    static class Islemler
    {

        public static long topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;

        }

        public static long Cikar(int sayi1,int sayi2)
        {

            return sayi1 - sayi2;
        }


    }
}
