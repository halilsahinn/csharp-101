using System;
using System.Collections.Generic;

namespace To_Do_Uygulamasi
{
    internal class Program
    {
        #region FIELDS
        private static List<TakimUyeleri> takimUyeleri;
        private static List<Kart> kartListesi;
        public static Surec surec;
        #endregion

        #region MAIN
        static void Main(string[] args)
        {

            InitializeList();
            Menu();
            Console.ReadLine();


        }
        #endregion

        #region METHODS
        static void InitializeList()
        {
            TakimUyesiSeed();
            surec = new Surec();
            kartListesi = new List<Kart>();
        }
        static void TakimUyesiSeed()
        {
            TakimUyeleri tk1 = new TakimUyeleri();
            tk1.Ad = "Halil";
            TakimUyeleri tk2 = new TakimUyeleri();
            tk2.Ad = "Ali";
            TakimUyeleri tk3 = new TakimUyeleri();
            tk3.Ad = "Ayşe";
            TakimUyeleri tk4 = new TakimUyeleri();
            tk4.Ad = "Mete";
            TakimUyeleri tk5 = new TakimUyeleri();
            tk5.Ad = "Merve";

            takimUyeleri = new List<TakimUyeleri>();
            takimUyeleri.Add(tk1);
            takimUyeleri.Add(tk2);
            takimUyeleri.Add(tk3);
            takimUyeleri.Add(tk4);
            takimUyeleri.Add(tk5);

        }
        static void Menu()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("* 1-Kart Ekle               *");
            Console.WriteLine("* 2-Kart Güncelle           *");
            Console.WriteLine("* 3-Kart Sil                *");
            Console.WriteLine("* 4-Kart Taşı               *");
            Console.WriteLine("* 5-Board Listeleme         *");
            Console.WriteLine("*****************************");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    YeniKartEkle();
                    break;
                case 2:
                    KartGuncelle();
                    break;
                case 3:
                    KartSil();
                    break;
                case 4:
                    KartTasi();
                    break;
                case 5:
                    KartListele();
                    break;

            }
            Menu();
        }
        static void TakimUyesiListele()
        {
            takimUyeleri.ForEach(x =>
            {
                Console.WriteLine(x.Ad);
            });
        }
        static void YeniKartEkle()
        {
            Console.WriteLine("Lütfen Başlık Yazınız");
            string baslik = Console.ReadLine();
            Console.WriteLine("Lütfen İçeriği Yazınız");
            string icerik = Console.ReadLine();
            Console.WriteLine("------------------------");
            TakimUyesiListele();
            Console.WriteLine("Lütfen Kişi Seçimi Yapınız");
            string atanan_kisi = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)");
            int buyukluk = Convert.ToInt32(Console.ReadLine());
            Kart kart = new Kart();
            kart.Baslik = baslik;
            kart.Icerik = icerik;
            kart.AtananKisi = atanan_kisi;
            kart.Buyukluk = buyukluk;

            kartListesi.Add(kart);
            surec.TODO.Add(kart);


        }
        static void KartGuncelle()
        {
            Console.WriteLine("Lütfen Güncellemek  İstediğiniz Kaydın Başlığını Giriniz");

            var str = Console.ReadLine();
            var result = KartBul(str);
            if (result == null)
            {
                Console.WriteLine("Böyle Bir Kayıt Bulunamadı");
            }
            else
            {
                Console.WriteLine("Lütfen Güncellemek İstediğiniz Bağlığı Giriniz");
                var strUpdate = Console.ReadLine();
                if (strUpdate != null)
                {

                    result.Baslik = strUpdate;
                    Console.WriteLine("Güncelleme İşlemi Başarılı");
                }


            }


        }
        static void KartTasi()
        {
            Console.WriteLine("Kart Listesi");
            Console.WriteLine("*********************");
            foreach (var item in surec.IN_PROGRESS)
            {
                Console.WriteLine("Başlık:{0}" + "->Durum: Başlandı", item.Baslik);
            }
            foreach (var item in surec.TODO)
            {
                Console.WriteLine("Başlık:{0}" + "->Durum: Yapılıyor", item.Baslik);
            }

            foreach (var item in surec.DONE)
            {
                Console.WriteLine("Başlık:{0}" + "->Durum: Tamamlandı", item.Baslik);
            }

            Console.WriteLine("*********************");
            Console.WriteLine("Lütfen Taşımak İstediğiniz Kaydı Yazınız");

            string line = Console.ReadLine();
            var result = KartBul(line);
            if (result == null)
            {
                Console.WriteLine("Böyle Bir Bulunumadı. Doğru Yazdığınızdan Emin Olunuz !");
                KartTasi();
                return;

            }
            string surecStr = KartSureciBul(result);
            Console.WriteLine("Lütfen Süreci Belirtiniz");
            Console.WriteLine("1- TODO");
            Console.WriteLine("2- IN_PROGRESS");
            Console.WriteLine("3- DONE");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (true)
            {

            }


            switch (secim)
            {
                case 1:
                    if (surecStr == "TODO")
                    {
                        Console.WriteLine("Süreç Zaten TODO'da");
                    }
                    else if (surecStr == "IN_PROGRESS")
                    {
                        surec.TODO.Add(result);
                        surec.IN_PROGRESS.Remove(result);

                    }
                    else if (surecStr == "DONE")
                    {
                        surec.TODO.Add(result);
                        surec.DONE.Remove(result);

                    }

                    break;
                case 2:
                    if (surecStr == "IN_PROGRESS")
                    {
                        Console.WriteLine("Süreç Zaten IN PROGRESS'de");
                    }
                    else if (surecStr == "TODO")
                    {
                        surec.IN_PROGRESS.Add(result);
                        surec.TODO.Remove(result);

                    }
                    else if (surecStr == "DONE")
                    {
                        surec.IN_PROGRESS.Add(result);
                        surec.DONE.Remove(result);

                    }


                    break;
                case 3:
                    if (surecStr == "DONE")
                    {
                        Console.WriteLine("Süreç Zaten DONE'da");
                    }
                    else if (surecStr == "TODO")
                    {
                        surec.DONE.Add(result);
                        surec.TODO.Remove(result);

                    }
                    else if (surecStr == "IN_PROGESS")
                    {
                        surec.DONE.Add(result);
                        surec.IN_PROGRESS.Remove(result);

                    }
                    break;


            }

            Console.WriteLine("Taşıma İşlemi Başarılı");

        }
        static void KartSil()
        {
            Console.WriteLine("Lütfen Silmek İstediğiniz Kartı Yazınız");
            var baslik = Console.ReadLine();

            var result = KartBul(baslik);

            if (result != null)
            {

                string kSurec = KartSureciBul(result);

                switch (kSurec)
                {
                    case "TODO":
                        surec.TODO.Remove(result);

                        break;

                    case "IN_PROGESS":
                        surec.IN_PROGRESS.Remove(result);
                        break;

                    case "DONE":
                        surec.DONE.Remove(result);
                        break;
                }
                kartListesi.Remove(result);

                Console.WriteLine("Kart Silindi");
            }
            else
            {
                Console.WriteLine("Böyle Bir Kart Bulunamadı");
            }



        }
        static Kart KartBul(string str)
        {
            var result = kartListesi.Find(x => x.Baslik == str);
            return result;

        }
        static void KartListele()
        {
            Console.WriteLine("TO DO Line");
            foreach (var item in surec.TODO)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Başlık:{0}", item.Baslik);
                Console.WriteLine("İçerik:{0}", item.Icerik);
                Console.WriteLine("Atanan Kişi:{0}", item.AtananKisi);
                Console.WriteLine("Büyüklük:{0}", EnumDonustur(item.Buyukluk));
            }

            Console.WriteLine("IN PROGRESS Line");
            foreach (var item in surec.IN_PROGRESS)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Başlık:{0}", item.Baslik);
                Console.WriteLine("İçerik:{0}", item.Icerik);
                Console.WriteLine("Atanan Kişi:{0}", item.AtananKisi);
                Console.WriteLine("Büyüklük:{0}", EnumDonustur(item.Buyukluk));
            }
            Console.WriteLine("DONE Line");
            foreach (var item in surec.DONE)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Başlık:{0}", item.Baslik);
                Console.WriteLine("İçerik:{0}", item.Icerik);
                Console.WriteLine("Atanan Kişi:{0}", item.AtananKisi);
                Console.WriteLine("Büyüklük:{0}", EnumDonustur(item.Buyukluk));
            }



        }
        static string EnumDonustur(int param)
        {
            string result = "";
            switch (param)
            {
                case 0:
                    result = "Sonuç Yok";
                    break;
                case 1:
                    result = "XS";
                    break;
                case 2:
                    result = "S";
                    break;

                case 3:
                    result = "M";
                    break;
                case 4:
                    result = "L";
                    break;

                case 5:
                    result = "XL";
                    break;

            }

            return result;

        }

        static string KartSureciBul(Kart kart)
        {
            string surecStr = "";

            foreach (var item in surec.IN_PROGRESS)
            {
                return surecStr = "IN_PROGRESS";
            }


            foreach (var item in surec.TODO)
            {
                return surecStr = "TODO";
            }


            foreach (var item in surec.DONE)
            {
                return surecStr = "DONE";
            }

            return surecStr;

        }
        #endregion

        #region ENUMS
        public enum Buyukluk
        {
            SonucYok = 0,
            XS = 1,
            S = 2,
            M = 3,
            L = 4,
            XL = 5
        }
        #endregion

    }

    #region MODELS
    public class Kart
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }

        public string AtananKisi { get; set; }

        public int Buyukluk { get; set; }

    }
    public class Surec
    {
        public Surec()
        {
            TODO = new List<Kart>();
            IN_PROGRESS = new List<Kart>();
            DONE = new List<Kart>();
        }


        public List<Kart> TODO { get; set; }
        public List<Kart> IN_PROGRESS { get; set; }
        public List<Kart> DONE { get; set; }


    }
    public class TakimUyeleri
    {
        public int Id { get; set; }
        public string Ad { get; set; }


    }

    #endregion



}
