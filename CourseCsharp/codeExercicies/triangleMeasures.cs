using System;
using System.Globalization;

namespace CourseCsharp.CodeExercises
{
    // Definindo a classe Triangle com as medidas dos lados

    // Definindo a classe TriangleMeasures para calcular áreas
    public class TriangleMeasures
    {
        public void CalculateTriangleAreas()
        {
            // Instanciando os triângulos
            Triangle X = new Triangle();
            Triangle Y = new Triangle();

            // Entrada de dados para o triângulo X
            Console.WriteLine("Entre com as medidas do triângulo X:");
            X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Entrada de dados para o triângulo Y
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calculando as áreas usando a fórmula de Herão
            double areaX = X.Area();
            double areaY = Y.Area();

            // Exibindo as áreas
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // Determinando qual triângulo tem a maior área
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área é do triângulo X");
            }
            else
            {
                Console.WriteLine("Maior área é do triângulo Y");
            }
        }
    }
}