namespace SolidSharp.Models
{
    internal class Square(double size) : Rectangle(size, size)
    {
        public double Size { get; }
    }
}
