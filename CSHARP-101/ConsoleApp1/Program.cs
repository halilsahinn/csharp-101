using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringChallenge("12:30pm - 12:00am");
            
            Console.ReadLine();

        }

        public static string StringChallenge(string str)
        {

            // code goes here

            var tmpStr = str.Split('-');

            var dt1StartDate = tmpStr[0];
            var dt1EndDate = tmpStr[1];

            DateTime dt1 = DateTime.Parse(dt1StartDate);
            DateTime dt2 = DateTime.Parse(dt1EndDate);



            //String.Format("{0:t}",dt1);
            //String.Format("{0:t}",dt1EndDate);



            // Console.WriteLine("--------------");
            //Console.WriteLine(dt1StartDate);
            //Console.WriteLine(dt1EndDate);
            //Console.WriteLine("--------------");

            TimeSpan dt11 =DateTime.ParseExact(dt1StartDate,"HH:mm tt",new DateTimeFormatInfo());
            //DateTime dt2=DateTime.ParseExact(dt1EndDate,"HH:mm tt",new DateTimeFormatInfo());
            TimeSpan timeSpan1 = new TimeSpan(dt11);
            TimeSpan timeSpan2 = new TimeSpan(12, 0, 0);
            var timeDiff = timeSpan2.Subtract(timeSpan1);


            Console.WriteLine(dt1.ToString());


            return str;

        }
    }
}
