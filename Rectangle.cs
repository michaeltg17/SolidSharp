namespace SolidSharp
{
    internal class Rectangle : Shape
    {
        public override decimal GetArea() => Height * Width;
        public override decimal GetPerimeter() => Height * 2 + Width * 2;
    }
}
