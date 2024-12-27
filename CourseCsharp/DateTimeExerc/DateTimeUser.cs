using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace CourseCsharp.DateTimeExerc
{
    internal class DateTimeUser
    {
        public void DateTimeShow()
        {
            DateTime date = new DateTime(2018,11,25);
            DateTime date2 = new DateTime(2018,11,25,20,45,3,DateTimeKind.Local);
            DateTime date3 = new DateTime(2018,11,25,20,45,03,500);

            DateTime date4 = DateTime.Now;
            DateTime date5 = DateTime.Today;
            DateTime date6 = DateTime.UtcNow;

            DateTime date7 = DateTime.Parse("2000-08-15");
            DateTime date8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime date9 = DateTime.Parse("15/08/2004 13:08");


            DateTime date10 = DateTime.ParseExact("2080-08-15","yyyy-mm-dd",CultureInfo.InvariantCulture);
            DateTime date11 = DateTime.ParseExact("27/12/2024 14:15","dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);

            Console.WriteLine(date);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);
            Console.WriteLine(date5);
            Console.WriteLine(date6);
            Console.WriteLine(date7);
            Console.WriteLine(date8);
            Console.WriteLine(date9);
            Console.WriteLine(date10);
            Console.WriteLine(date11);

        }
    }
}
