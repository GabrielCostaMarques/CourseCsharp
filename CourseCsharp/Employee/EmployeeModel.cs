using System;
using System.Globalization;

namespace CourseCsharp.Employee
{
    internal class EmployeeModel
    {
        public string Name { get; set; }
        public double GrossSalary { get; set; }
        public double Taxation { get; set; }



        public double NetSalary()
        {
            return GrossSalary - Taxation;
        }


        public double UpdateSalary(double porcent)
        {
            return GrossSalary += (GrossSalary * porcent / 100.0);
            ;
        }

        public override string ToString()
        {
            return "Funcionário: "
                + Name
                + ", $"
                + NetSalary().ToString("f2", CultureInfo.InvariantCulture);
        }
    }

}
