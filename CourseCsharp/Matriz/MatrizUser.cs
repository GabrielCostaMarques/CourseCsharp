using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.Matriz
{
    internal class MatrizUser
    {
        public void MatrizShow()
        {   
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));


            //entrada de dados

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);         
                }
            }

            //percorrendo a main diagonal, ele percorre a matriz e imprime apenas quando o numero da linha é igual da coluna
            Console.WriteLine("Main diagonal: ");

            for (int i = 0; i < n; i++)
            {

                Console.Write(mat[i,i]+" ");
            }

            Console.WriteLine();

            //percorrer uma matriz inteira e verificar se tem negativo
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (mat[i,j]<0)
                    {
                        count++;
                    }
                }
            }

            Console.Write("Negative Numbers: "+ count);

        }

    }
}
