using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Tanimlama_Erissim_Ve_Donguulerle_Dizi_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[10];
            sayilar[2] = 12;

           // string[] renkler = { "Mavi", "Kırmızı", "Sarı", "Yeşil" };

            int[] dizi;
            dizi = new int[4];

            string[] renkler = { "Mavi", "Kırmızı", "Sarı", "Yeşil" };
            string renk = renkler[1]; // Kırmızı rengi getirir.


            int[] sayiDizisi = new int[20];
            int toplam = 0;
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.Write("Lütfen {0}. sayıyı girin:", i + 1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayiDizisi[i];
            }
            double ortalama = toplam / 20;
            Console.WriteLine("Sayıların ortalaması: " + ortalama);
            Console.ReadLine();
        }
    }
}
