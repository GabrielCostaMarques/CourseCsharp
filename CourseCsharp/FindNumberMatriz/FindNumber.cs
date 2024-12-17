using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.FindNumberMatriz
{
    internal class FindNumber
    {

        public void FindNumberShow()


        {


            Console.Write("Type the number of matriz - rows: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Type the number of matriz - columns: ");
            int n = int.Parse(Console.ReadLine());





            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.Write("What the number you wanna find around?: ");

            int findNumber = int.Parse(Console.ReadLine());



            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == findNumber)
                    {
                        Console.WriteLine("Position: " + i + "," + j);

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }




        }
    }
}
