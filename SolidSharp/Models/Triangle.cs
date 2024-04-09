namespace SolidSharp.Models
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
            var semiperimeter = (Side1 + Side2 + Side3) / 2;
            Area = Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3));
        }

        void CalculatePerimeter()
        {
            Perimeter = Side1 + Side2 + Side3;
        }
    }
}
