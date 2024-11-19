


using CourseCsharp.RadianCalculate;
using System.Globalization;

namespace CourseCsharp.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circuferencia(raio);
            double volume = Calculator.Volume(raio);

            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: "+volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: "+ Calculator.pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        
    }
}

