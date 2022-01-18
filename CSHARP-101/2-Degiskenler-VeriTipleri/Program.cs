using System;

namespace _2_Degiskenler_VeriTipleri
{
    internal class Program
    {

        /// <summary>
        /// Değişken Tipleri 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {



            //Tamsayı Değişken Tipleri (Integer Variable Types)
            sbyte sByte = 127;// sbyte.MaxValue; 
            byte bByte = 255;// byte.MaxValue;
            short sShort = 32767; //short.MaxValue ;
            ushort uuShort = 65535;//ushort.MaxValue;
            int IInt = 2147483647; //int.MaxValue;
            uint uInt = 4294967295; //uint.MaxValue;
            long lLong = 1000000000000000000;//long.MaxValue
            ulong uuLong = 10000000000000000000;// ulong.MaxValue

            //Kesirli Sayı Değişken Tipleri (Floating Point Variables)
            float fFloat = float.MaxValue;
            double dFloat = double.MaxValue;

            char cChar = 'H';

            //String Veri Tipi
            string sString = "Halil";
            string ssString = null;

            //Boolean Veri Tipi
            bool bBool = true;

            Console.WriteLine("Değişken Tipleri");
            Console.ReadLine();

        }
    }
}
