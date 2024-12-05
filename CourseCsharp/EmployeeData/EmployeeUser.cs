using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.EmployeeData
{
    internal class EmployeeUser
    {

        public void EmployeeShow()
        {
            List<EmployeeModal> employee = new List<EmployeeModal>();


            Console.Write("How many employess will be registered?");
            int register = int.Parse(Console.ReadLine());

            for (int i = 0; i < register; i++)
            {

                Console.WriteLine("Employee #" + (i + 1));

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("");
                Console.WriteLine("-------------------------");

                employee.Add(new EmployeeModal(id, name, salary));
            }

            Console.Write("Enter the employee id that will have increase: ");
            int chooseId = int.Parse(Console.ReadLine());


            EmployeeModal emp = employee.Find(x => x.Id == chooseId);

            if (emp != null)
            {

                Console.Write("Enter the percentage: ");
                double increment = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.CalculateBonus(increment);

            }
            else
            {
                Console.WriteLine("this Id not exist");

            }
                Console.WriteLine("");
            foreach (EmployeeModal item in employee)
            {
                Console.WriteLine(item);
            }
        }
    }
}
