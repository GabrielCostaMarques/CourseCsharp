using System.Globalization;


namespace CourseCsharp.Employee
{
    internal class EmployeeUser
    {
        EmployeeModel employ = new EmployeeModel();


        public void EmployeeShow()
        {
            Console.WriteLine("Entre os dados do funcionário ");

            Console.Write("NOME: ");
            employ.Name = Console.ReadLine();


            Console.Write("Salário Bruto: ");
            employ.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Impostos: ");
            employ.Taxation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Funciónário: "+employ);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double tx = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            employ.UpdateSalary(tx);

            Console.WriteLine("Dados Atualizados" + employ);

        }

    }
}




