using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.DateTimeOperators
{
    internal class OperatorsUser
    {
        public void OperatorsShow()
        {
            DateTime d = new DateTime(2004, 3, 30, 13, 45, 58, 275);

            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(5);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);


            DateTime d4 = new DateTime(2000,10,15);
            DateTime d5 = new DateTime(2000,10,22);

            TimeSpan t = d4.Subtract(d5);



        }
    }
}
