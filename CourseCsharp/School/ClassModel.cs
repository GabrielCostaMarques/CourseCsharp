using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.School
{
    internal class ClassModel
    {
        public string Name { get; set; }
        public double Grade { get; set; }



        string j;
        public bool Decision(double grade)
        {

            if (grade >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double LeftGrade(double grade)
        {
            if (Decision(Grade))
            {
                return 0.0;
            }
            else
            {
                return 60 - grade;
            }
        }

    }
}