using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collection namepsace

            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            //AddRange

            Console.WriteLine("*****AddRange*****************");
           // string [] renkler = {"mavi,Siyah,Beyaz" };
            List<int> sayilar = new List<int>() {11,1,2,3,6,7,8,9 };   
            
           // liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            //Sort
            Console.WriteLine("******Sort**********");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            //Binary Search

            Console.WriteLine("*******Binary Search***");
          
            Console.WriteLine(liste.BinarySearch(9));


            //Reverse

            Console.WriteLine("********Reverse********");

            liste.Reverse();
            
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("*******Clear*******");
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }







            Console.ReadLine();

        }
    }
}
