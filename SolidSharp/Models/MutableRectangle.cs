namespace SolidSharp.Models
{
    public class MutableRectangle : Shape
    {
        double length;
        public virtual double Length
        {
            get { return length; }
            set
            {
                length = value;
                CalculateArea();
                CalculatePerimeter();
            }
        }

        double width;
        public virtual double Width
        {
            get { return width; }
            set
            {
                width = value;
                CalculateArea();
                CalculatePerimeter();
            }
        }

        public MutableRectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            CalculateArea();
            CalculatePerimeter();
        }

        protected void CalculateArea() => Area = Length * Width;
        protected void CalculatePerimeter() => Perimeter = 2 * (Length + Width);
    }
}
