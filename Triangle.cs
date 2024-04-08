using System.Runtime.CompilerServices;

namespace SolidSharp
{
    internal class Triangle : Shape
    {
        public Triangle(decimal base) { }

        public override decimal GetArea() => (decimal)Math.PI * Radius;
        public override decimal GetPerimeter() => 2 * (decimal)Math.PI * Radius;
    }
}
