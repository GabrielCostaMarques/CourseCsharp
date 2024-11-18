using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace CourseCsharp.School
{
    internal class ClassUser
    {
        ClassModel student = new ClassModel();

        public void StudentShow()

        {
            int j = 3;

            Console.WriteLine("Nome do Aluno: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Digite as notas trimestrais do aluno: ");

            for (int i = 0; i < j; i++)
            {

                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                student.Grade += nota;

            }

            Console.WriteLine("NOTA FINAL: " + student.Grade.ToString("f2", CultureInfo.InvariantCulture));
            if (student.Decision(student.Grade))
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }

            Console.WriteLine("FALTARAM "+student.LeftGrade(student.Grade)+" PONTOS");



        }

    }

}
