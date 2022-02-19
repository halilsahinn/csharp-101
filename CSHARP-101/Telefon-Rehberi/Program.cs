using System;
using System.Collections.Generic;

namespace Telefon_Rehberi
{
    internal class Program
    {
        private static List<Member> lstMember = new List<Member>();


        static void Main(string[] args)
        {


            GirisMenu();

            Console.ReadLine();

        }

        static void GirisMenu()
        {

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine("****************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetme");
            Console.WriteLine("(2) Var Olan Numarayı Silmek");
            Console.WriteLine("(3) Yeni Numara Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("****************************************");

            int secim = Convert.ToInt32(Console.ReadLine());


            switch (secim)
            {

                case 1:
                    RehberYeniKayit();
                    break;

                case 2:
                    RehberKayitSil();
                    break;

                case 3:
                    RehberKayitGuncelle();
                    break;

                case 4:
                    RehberListele();
                    break;

                case 5:
                    Console.WriteLine("Aramak istediğiniz Abone Adını Girniz");
                    string ad = Console.ReadLine();

                    RehberKayitBul(ad);
                    break;

            }
            GirisMenu();


        }
        static void RehberYeniKayit()
        {
            Member member = new Member();

            Console.WriteLine("Lütfen Adınızı Giriniz");
            var name = Console.ReadLine();
            member.Name = name;

            Console.WriteLine("Lütfen SoyAdınızı Giriniz");
            var surName = Console.ReadLine();
            member.SurName = surName;

            Console.WriteLine("Lütfen Telefon Numaranızı Giriniz");
            var telephone = Console.ReadLine();
            member.TelephoneNumber = telephone;
            lstMember.Add(member);
            Console.WriteLine("Kayıt Eklenmiştir");
            Console.WriteLine("**********************************");
        }
        static void RehberKayitGuncelle()
        {
            Console.WriteLine("Lütfen Güncellemek İstediğiniz İsmi Yazınız");
            string ad = Console.ReadLine();

            var result = lstMember.Find(x => x.Name == ad);

            if (lstMember.Contains(result))
            {
                Console.WriteLine("Lütfen Güncellemek İstediğiniz Telefon Numarasını Giriniz");
                string tNumber = Console.ReadLine();

                result.TelephoneNumber = tNumber;

                Console.WriteLine("başarılı Bir Şekilde Güncellendi");


            }
            else
            {
                Console.WriteLine("Böyle Bir Kayıt Bulunamadı");
            }

        }

        static void RehberKayitSil()
        {
            Console.WriteLine("Lütfen Silmek İstediğiniz İsmi Yazınız");
            string name = Console.ReadLine();

            var result = lstMember.Find(x => x.Name == name);
            if (lstMember.Contains(result))
            {

                lstMember.Remove(result);
                Console.WriteLine("Kayıt Başarıyla Silindi");

            }

            else
            {
                Console.WriteLine("Böyle Bir Kayıt Bulunamadı");
            }



        }

        static void RehberListele()
        {

            if (lstMember.Count > 0)
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                Console.Write("|");
                Console.Write("Adı");
                Console.Write("|");
                Console.Write("SoyAdı");
                Console.Write("|");
                Console.Write("Telefon Numarası");
                Console.Write("|");

                Console.WriteLine();
                for (int i = 0; i < 30; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                int uzunluk;

                foreach (var item in lstMember)
                {
                    uzunluk = ((item.Name + item.SurName + item.TelephoneNumber).Length) + 4;


                    Console.WriteLine("|{0}|{1}|{2}|", item.Name, item.SurName, item.TelephoneNumber);

                    for (int i = 0; i < uzunluk; i++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();

                }
            }

            else
            {
                Console.WriteLine("Listelenecek Kayıt Bulunamadı");

            }


        }
        static void RehberKayitBul(string name)
        {

            var result = lstMember.Find(x => x.Name == name);

            if (lstMember.Contains(result))
            {
                Console.WriteLine("**********Aradığınız Kayıt************");
                Console.WriteLine("Adı: {0}", result.Name);
                Console.WriteLine("Adı: {0}", result.SurName);
                Console.WriteLine("Adı: {0}", result.TelephoneNumber);
            }
            else
            {
                Console.WriteLine("Böyle Bir Kayıt Bulunamadı");
            }

            Console.WriteLine("******************************");
        }
        class Member
        {
            public int Id { get; set; }

            public string Name { get; set; }
            public string SurName { get; set; }

            public string TelephoneNumber { get; set; }


        }


    }
}
