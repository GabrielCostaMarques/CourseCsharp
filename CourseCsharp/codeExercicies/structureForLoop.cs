using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.codeExercicies
{
    public class structureForLoop
    {
        public void ForLoop()
        {

            Console.WriteLine("Teste");

            Console.WriteLine("Quanto numero inteiros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Valor" + i + "#: ");
                int number = int.Parse(Console.ReadLine());
                soma = number + soma;
            }
            Console.WriteLine("Seu numero é - " + soma);

        }

    }
}
