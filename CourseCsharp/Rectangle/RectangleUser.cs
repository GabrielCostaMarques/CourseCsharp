using System;
using System.Globalization;


namespace CourseCsharp.Rectangle
{
    internal class RectangleUser
    {
        RectangleModel calculate = new RectangleModel();


        public void RectangleShow()
        {
            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            calculate.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            calculate.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("ÁREA: "+ calculate.CalculateArea());
            Console.WriteLine();
            Console.Write("PERÍMETRO: "+ calculate.CalculatePerimeter());
            Console.WriteLine();
            Console.Write("DIAGONAL: "+ calculate.CalculateDiagonal());

        }

    }
}






