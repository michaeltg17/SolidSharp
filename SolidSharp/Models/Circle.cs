namespace SolidSharp.Models
{
    internal class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * Radius * Radius;
            Perimeter = 2 * Math.PI * Radius;
        }
    }
}
