using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.DateTimeProprieties
{
    internal class ProprietiesUser
    {
        public void DateTimeProprietiesShow()
        {

            DateTime d = new DateTime(2004, 3, 30, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: "+ d.Date);
            Console.WriteLine("2) Day: "+ d.Day);
            Console.WriteLine("3) DayOfWeek: "+ d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: "+ d.DayOfYear);
            Console.WriteLine("5) Hour: "+ d.Hour);
            Console.WriteLine("6) Kind: "+ d.Kind);
            Console.WriteLine("7) Milisecond: "+ d.Millisecond);
            Console.WriteLine("8) Minute: "+ d.Minute);
            Console.WriteLine("9) Month: "+ d.Month);
            Console.WriteLine("10) Second: "+ d.Second);
            Console.WriteLine("11) Ticks: "+ d.Ticks);
            Console.WriteLine("12) TimeOfDay: "+ d.TimeOfDay);
            Console.WriteLine("13) Year: "+ d.Year);


            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());

            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));




        }
    }
}
