using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Atama Ve İşlemli Atama
            int x = 3;
            int y = 3;
            y = y + x;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Mantıksal Operatörler

            bool IsSuccess = true;
            bool IsCompleted = false;

            if (IsSuccess && IsCompleted)
            {
                Console.WriteLine("Perfect");
            }

            if (IsSuccess || IsCompleted)
            {
                Console.WriteLine("Great");
            }

            if (IsSuccess && IsCompleted)
            {
                Console.WriteLine("Fine");
            }

            //İlişkisel Operatörler
            int a = 3, b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            //Aritmetik Oparotörler

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            //% Mod Alır

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);












        }
    }
}
