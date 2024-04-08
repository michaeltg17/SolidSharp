namespace SolidSharp
{
    internal abstract class Shape
    {
        public required decimal Height { get; set; }
        public required decimal Width { get; set; }

        public abstract decimal GetPerimeter();
        public abstract decimal GetArea();
    }
}
