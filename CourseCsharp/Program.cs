// See https://aka.ms/new-console-template for more information

using System;


namespace CourseCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste");

            Console.WriteLine("Quanto numero inteiros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Oi");
            }
        }
    }
}