using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Array_Sınıfı_Methodları
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayiDizisi = { 23, 12, 4, 86, 72,3,11, 17};

            Console.WriteLine("Sırasız Dizi");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            Array.Sort(sayiDizisi);

            Console.WriteLine("Sıralı Dizi");

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Array.Clear() Sayı Dizisinden itibaren 2.index ten itibaren 2 tane elemanı 0'lar

            Array.Clear(sayiDizisi,2,2);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            //Reverse
            Console.WriteLine("Array Reverse");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }



            //IndexOf() sayı dizisi içersinde hangi değer kaçıncı index te
            Console.WriteLine("IndexOf");
           
            
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //ReSize

            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayiDizisi, 9); ;
            sayiDizisi[8] = 99;

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
