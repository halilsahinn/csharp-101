using System;

namespace _17_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int Sicaklik = 32;

            if (Sicaklik <= (int)HavaSicakligi.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyin");
            }
            else if (Sicaklik >= (int)HavaSicakligi.Sicak)
            {
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
            }
            else if (Sicaklik >= (int)HavaSicakligi.Normal && Sicaklik < (int)HavaSicakligi.CokSicak)
            {
                Console.WriteLine("Haydi dışarıya çıkalım");
            }

            Console.ReadLine();

        }


        enum Gunler
        {
            Pazartesi,
            Sali,
            Carsamba,
            Persembe,
            Cuma,
            Cumartesi,
            Pazar



        }

        enum HavaSicakligi
        {

            Soguk = 5,
            Normal = 20,
            Sicak = 25,
            CokSicak = 30

        }
    }
}
