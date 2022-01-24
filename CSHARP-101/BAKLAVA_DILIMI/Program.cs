using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAKLAVA_DILIMI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi;

            sayi = 20;
        
            for (int i = 0; i <= sayi; i++)
            {
                
                for (int j = sayi; j > i ; j--)
                {
                    Console.Write(" ");
                    
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" " + "*");
                }
            Console.WriteLine();

            }
            
            
            


          


            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = sayi; k > i; k--)
                {
                    Console.Write(" " + "*");
                }
                
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
