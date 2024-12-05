using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml;

namespace CourseCsharp.Lists

{
    internal class List
    {

        public void ListShow()
        {

            List<string> list = new List<string>();

            list.Add("Alex");
            list.Add("Joao");
            list.Add("Ana");
            list.Add("Bobby");
            list.Add("NADA");

            list.Insert(1, "Marcelo");

            list.Count();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("list count " + list.Count);

            //expressao lambda "função anônima"
            //---------------------------------------------------
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);

            //---------------------------------------------------

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            //---------------------------------------------------


            int pos1 = list.FindIndex(x => x[0] == 'A');

            Console.WriteLine("First Position 'A': " + pos1);

            //---------------------------------------------------x


            int pos2 = list.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine("First Position 'A': " + pos2);

            //---------------------------------------------------
            Console.WriteLine("------------------------------------------");
            List<string> list3 = list.FindAll(x => x.Length == 4);

            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }


            //---------------------------------------------------
            list.Remove("Alex");

            Console.WriteLine("------------------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------");
            list.RemoveAll(x => x[0] == 'M');

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------");

            list.RemoveAt(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------");
            list.RemoveRange(0, 2);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
