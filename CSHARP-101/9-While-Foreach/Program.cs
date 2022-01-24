using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_While_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak console dan girilen sayıya kadar ortalama hesaplayıp  console a yazdıran program
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;



            }
            Console.WriteLine(toplam/sayi);


            //a dan z ye kadar tüm harfleri console a yazdır
            char character = 'a';

            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine("");
            //Foreach 
            string[] dizi =  { "BMV", "FORD", "TOYOTA" };

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
