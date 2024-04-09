namespace SolidSharp.Models
{
    internal class MutableSquare(double sideLength) : MutableRectangle(sideLength, sideLength)
    {
        double length;
        public override double Length
        {
            get { return length; }
            set
            {
                length = value;
                width = value;
                CalculateArea();
                CalculatePerimeter();
            }
        }

        double width;
        public override double Width
        {
            get { return width; }
            set
            {
                width = value;
                length = value;
                CalculateArea();
                CalculatePerimeter();
            }
        }
    }
}
