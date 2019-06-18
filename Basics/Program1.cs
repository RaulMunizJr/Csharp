using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice0
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //                                      Sring Formats 
            var city = "Dallas";
            var temperature = 103.4f;
            var currentDt = DateTime.Now;
            Console.Write(string.Format("Welcome to {0}. The time is {1:t}. the temperature is {2:0.00}.", city, currentDt, temperature));
            //t short time format
            //T longer time format
            //0.00 104.40

            

            /*************************************************************************************/

            //int.Parse("15,234"); doesn't work!
            var test = "15,234";
            Console.Write(int.Parse(test.Replace(",", "")));


            int result;
            Console.Write(int.TryParse("15,234", out result)); //false
            Console.Write(int.TryParse("15234", out result)); //true

            /*************************************************************************************/

            const float pi = 3.14f;

            enum weekDays {Monday, Tuesday, Wednesday, Thursday, Friday};
            var someDay = weekDays.Monday;

            enum weekDays2 {Monday = 1, Tuesday, Wednesday, Thursday, Friday};
            var someDay2 = weekDays.Wednesday; //3

            /*************************************************************************************/

            //              Time
            var birthday = new DateTime(1967, 12, 19); // year, month, day
            var difference = DateTime.Now - birthday; //not helpful
            //difference.Days;      gives the number of days
            //difference.Days/365;  will give you the years
            var someTime = new DateTime(2017, 10, 18, 9, 51, 32); //hr, min, sec added
            someTime.AddMinutes(134); //minutes added
            someTime.AddMinutes(-30); //sub
            someTime.ToFileTime(); //13152819092000000000
            Console.Write(someTime.ToLongDateString()); // Wednesday, October 18, 2017

            /*************************************************************************************/


        }
    }
}
