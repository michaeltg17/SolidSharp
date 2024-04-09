namespace SolidSharp.Models
{
    internal class Rectangle : Shape
    {
        public double Length { get; }
        public double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            Area = length * width;
            Perimeter = 2 * (length + width);
        }

        //SRP Violation => moved to RectangleService
        public static IEnumerable<Rectangle> IncreaseAreaByTenPercent(IEnumerable<Rectangle> rectangles)
        {
            throw new NotImplementedException();
        }
    }
}
