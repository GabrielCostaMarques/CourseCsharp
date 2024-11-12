using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.codeExercicies
{
    internal class Oldest
    {
        public void OldestCode()
        {
            Person person1 = new Person();
            Person person2 = new Person();

           
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            person1.Name = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            person1.Year = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            person2.Name = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            person2.Year = int.Parse(Console.ReadLine());

            // Instanciando a classe para fazer a comparação
            Person calculator = new Person();
            calculator.CalculateOldest(person1, person2);
        }
    }
}
