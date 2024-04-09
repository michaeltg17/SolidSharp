namespace SolidSharp.Models
{
    public abstract class Shape
    {
        public int Sides { get; protected set; }
        public double Area { get; protected set; }
        public double Perimeter { get; protected set; }

        //ISP Violation - Not all shapes have a Radius so it should be moved to derived class
        //or interface/class if more than one derived class uses it and inherits it. Otherwise a Rectangle will have it.
        public double Radius { get; }
    }
}
