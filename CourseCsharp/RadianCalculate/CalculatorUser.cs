using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.RadianCalculate
{
    internal class CalculatorUser
    {
        public void CalculatorShow()
        {
            Console.WriteLine("Entre com o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circuferencia(raio);
            double volume = Calculator.Volume(raio);

            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculator.pi.ToString("F2", CultureInfo.InvariantCulture));
        }


    }
}
