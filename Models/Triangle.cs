﻿namespace SolidSharp.Models
{
    internal class Triangle : Shape
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            CalculateArea();
            CalculatePerimeter();
        }

        void CalculateArea()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            Area = Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        void CalculatePerimeter()
        {
            Perimeter = Side1 + Side2 + Side3;
        }
    }
}
