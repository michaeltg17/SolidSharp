using SolidSharp.Models;

namespace SolidSharp
{
    internal static class ShapeService
    {
        //OCP Violation - New shape types require method modifications. Next method is the correct one.
        public static double SumArea(IEnumerable<object> shapes)
        {
            return shapes.Sum(shape =>
            {
                if (shape is Rectangle rectangle) return rectangle.Length * rectangle.Width;
                else if (shape is Circle circle) return 0;
                else return 1;
            });
        }

        public static double SumArea(IEnumerable<Shape> shapes) => shapes.Sum(s => s.Area);
    }
}
