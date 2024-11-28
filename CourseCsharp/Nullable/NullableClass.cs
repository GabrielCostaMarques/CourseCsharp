using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CourseCsharp.Nullable
{
    internal class NullableClass
    {
        public void NullableClassUser()
        {
            double? x = null;

            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);

            }
            else
            {
                Console.WriteLine("X é null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y é null");
            }

            double? z = null;
            double? e = 10;

            double a = z ?? 5;
            double b = e ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);



        }

    }
}
