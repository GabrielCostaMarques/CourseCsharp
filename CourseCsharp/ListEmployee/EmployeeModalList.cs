using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.EmployeeData
{
    internal class EmployeeModalList
    {
        public int Id {  get; set; }
        public string Name {  get; set; } 
        public double Salary {  get; private set; }

        public EmployeeModalList()
        {
           
        }

        public EmployeeModalList(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public double CalculateBonus(double update)
        {
           return Salary += Salary * update / 100.0;
        }

        public override string ToString()
        {
            return Id+", "+Name+", "+Salary;
        }
    }
}
