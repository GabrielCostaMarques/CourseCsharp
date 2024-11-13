using System;

namespace CourseCsharp.Rectangle
{
    internal class RectangleModel
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public double CalculateArea()
        {
            return Width * Height;


        }


        public double CalculatePerimeter()
        {
            return  (Width + Height)*2;



        }

        public double CalculateDiagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }

    }
}
