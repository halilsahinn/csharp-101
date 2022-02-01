using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Hazir_Metodlar_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp Hoşgeldiniz";
            string degisken2 = "CSharp";

            //Lenght
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken,": Halil"));

            //Compare , CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken, degisken2,true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoş Geldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Halil"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert

            Console.WriteLine(degisken.Insert(0,"Merhaba"));


            //PadLeft, PadRight

            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);


            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace

            Console.WriteLine(degisken.Replace("Csharp","c#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split

            Console.WriteLine(degisken.Split(' ')[1]);

            //SubString

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));















            Console.ReadLine();

        }
    }
}
