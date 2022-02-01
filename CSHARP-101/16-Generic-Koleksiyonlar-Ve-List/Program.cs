using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_Generic_Koleksiyonlar_Ve_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);


            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count

            Console.WriteLine(renkListesi.Count());
            Console.WriteLine(sayiListesi.Count());

            //ForEach Ve List.ForEach İle Elemanlara Erişme

            foreach (var item in renkListesi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }

            sayiListesi.ForEach(item => Console.WriteLine(item));
            renkListesi.ForEach(item => Console.WriteLine(item));


            //Listeden Eleman Çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            sayiListesi.RemoveAt(1);


            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach((item) => Console.WriteLine(item));


            //Liste İçerisinde arama yapma

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Sayısı Listes İçerisinde Bulundu");
            }

            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //Diziyi List'e çevirme

            string[] hayvalar = { "Kedi", "Köpek", "Kuş" };

            List<string> hayvalarListesi = new List<string>(hayvalar);

            //Listeyi Temizleme
            hayvalarListesi.Clear();

            //List İçerisinde nesne tutma

            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Halil";
            kullanici1.Soyisim = "ŞAHİN";
            kullanici1.Yas = 36;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Ali";
            kullanici2.Soyisim = "ŞAHİN";
            kullanici2.Yas = 32;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar
            {
                Isim = "Ecenaz",
                Soyisim = "Bozoğlu",
                Yas = 30


            });


            foreach (var item in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+ item.Isim);
                Console.WriteLine("Kullanıcı SoyAdı: " + item.Soyisim);
                Console.WriteLine("Kullanıcı Yaş: " + item.Yas);
            }


            Console.ReadLine();

            yeniListe.Clear();
        }
    }

    public class Kullanicilar
    {


        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }

}
