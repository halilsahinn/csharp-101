using System;

namespace AlgoritmaSorulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************");
            Console.WriteLine("Lütfen Bir Sayı Giriniz");

            try
            {
                int sayi =Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Lütfen {sayi} adet sayi giriniz");

                for (int i = 0; i < sayi; i++)
                {
                    Console.WriteLine($"{i} nci sayısı giriniz");
                    
                    int tmpSayi=Convert.ToInt32(Console.ReadLine());
                    if (tmpSayi % 2 == 0)
                    {
                        Console.WriteLine("Sayı Çift");
                    }

                }

                

                Console.WriteLine("************************");

                Console.WriteLine("Lütfen iki tane pozitif sayı giriniz");

                int n=Convert.ToInt32(Console.ReadLine()); 

                int m=Convert.ToInt32(Console.ReadLine()); 


                for (int i = 0;i <= n; i++)
                {

                    Console.WriteLine($"Lütfen{i} nci sayıyı giriniz");
                    int tmpSayi = Convert.ToInt32(Console.ReadLine());

                    if (tmpSayi == m || tmpSayi % 2==0)
                    {

                        Console.WriteLine($"M Sayısına Eşit yada Tam Bölüneni: {i}");
                    }


                }

                Console.WriteLine("************************");

                Console.WriteLine("Lütfen iki tane pozitif sayı giriniz");



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}
