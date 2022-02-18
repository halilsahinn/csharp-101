using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace AlgoritmaSorulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. " +
           "Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.");
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

                

                Console.WriteLine("Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). " +
                    "Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.");

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

                Console.WriteLine("Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin." +
                    " Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın");

                Console.WriteLine("Lütfen iki tane pozitif sayı giriniz");
                List<string> tmpWords = new List<string>();
                int tmpInputSayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen {0} adet kelime giriniz",tmpInputSayi);

                string InputWord;
                for (int i = 0; i < tmpInputSayi; i++)
                {
                    Console.WriteLine("Lütfen {0} nci kelimeyi giriniz",i);
                    InputWord = Console.ReadLine();
                    tmpWords.Add(InputWord);

                }

                tmpWords.Reverse();
                tmpWords.ForEach(x => Console.WriteLine(x));

            
                
                Console.WriteLine("Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. " +
                    "Cümledeki toplam kelime ve harf sayısını console'a yazdırın");

                Console.WriteLine("Lütfen Bir Cümle Yazın");

                string InputSentence = Console.ReadLine();

                
                
                int CharacterCount = 0;

                int WordCount = InputSentence.Split(' ').ToList().Count;

                Console.WriteLine("Kelime Sayısı: {0}",WordCount);


                foreach (char item in InputSentence)
                {
                    CharacterCount++;
                }

               

                Console.WriteLine("Harf Sayısı: {0}", CharacterCount);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }

      


    }
}
