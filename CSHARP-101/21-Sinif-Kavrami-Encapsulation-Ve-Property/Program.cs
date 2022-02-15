using System;

namespace _21_Sinif_Kavrami_Encapsulation_Ve_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci= new Ogrenci();
            ogrenci.Isim = "Halil";
            ogrenci.Soyisim = "ŞAHİN";
            ogrenci.OgrenciNo = 12524555;
            ogrenci.Sinif = 2;

            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifDusur();

            ogrenci.OgrenciBilgileriniGetir();


            Ogrenci ogrenci1 = new Ogrenci("Ali","ŞAHİN",1123,1);
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();

            Console.ReadLine();

        }
    }

    class Ogrenci
    {
        public Ogrenci()
        {

        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { get => sinif; set {
                if (value<=1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir..");
                    sinif = 1;
                }
                
                sinif = value;}
        }


        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("**********Öğrenci Bilgileri********");
            Console.WriteLine($"Öğrenci Adı: {Isim}");
            Console.WriteLine($"Öğrenci SoyAdı: {Soyisim}");
            Console.WriteLine($"Öğrenci No: {OgrenciNo}");
            Console.WriteLine($"Sınıfı    : {Sinif}");


        }

        public void SinifAtlat()
        {

            Sinif += 1;
        }

        public void SinifDusur()
        {
            Sinif -= 1;

        }

    }


}
