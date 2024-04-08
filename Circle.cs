namespace SolidSharp
{
    internal class Circle : Shape
    {
        public Circle(decimal radius)
        {
            Radius = radius;
            Height = Radius * 2;
            Width = Radius * 2;
        }

        public decimal Radius { get; private set; }
        public override decimal GetArea() => (decimal)Math.PI * Radius;
        public override decimal GetPerimeter() => 2 * (decimal)Math.PI * Radius;
    }
}
