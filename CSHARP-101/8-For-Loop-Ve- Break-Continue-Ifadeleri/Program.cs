﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_For_Loop_Ve__Break_Continue_Ifadeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayac=int.Parse(Console.ReadLine());

            for (int i = 0; i <= sayac; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }

                
            }

            //1 ile 100 arasındaki tek ve  çift sayıların içlerinde toplamlarını ekrana yazdır
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }

                else
                {
                    ciftToplam += i;
                }
            }

           
            Console.WriteLine("Tek Toplam:" + tekToplam);
            Console.WriteLine("Çift Toplam:" + ciftToplam);


            //Break ve Countiune Kullanımı


            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break;

                }

                Console.WriteLine(i);
            }


            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;

                }

                Console.WriteLine(i);
            }


            Console.ReadLine();
        }
    }
}
