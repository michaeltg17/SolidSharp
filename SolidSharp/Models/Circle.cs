namespace SolidSharp.Models
{
    internal class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
            Sides = 1;
            Area = Math.PI * Radius * Radius;
            Perimeter = 2 * Math.PI * Radius;
        }
    }
}
