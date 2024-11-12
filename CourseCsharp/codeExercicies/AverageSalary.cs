using System;
using System.Globalization;


namespace CourseCsharp.codeExercicies
{
    internal class AverageSalary
    {
        public AverageSalary()
        {
            Person person1 = new Person();
            Person person2 = new Person();

            // Coletando dados da primeira pessoa
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            person1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            person1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Coletando dados da segunda pessoa
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            person2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            person2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Instanciando a classe para fazer a comparação
            Person calculator = new Person();
            calculator.CalculateAverageSalary(person1, person2);
        }
    }
}
