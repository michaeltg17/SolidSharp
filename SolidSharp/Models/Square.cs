namespace SolidSharp.Models
{
    internal class Square(double sideLength) : Rectangle(sideLength, sideLength)
    {
        public double SideLength { get; }
    }
}
