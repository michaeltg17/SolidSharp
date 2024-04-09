using SolidSharp.Models;

namespace SolidSharp
{
    internal static class RectangleService
    {
        public static IEnumerable<Rectangle> IncreaseAreaByTenPercent(IEnumerable<Rectangle> rectangles)
        {
            foreach (var rectangle in rectangles) 
            {
                yield return new Rectangle(rectangle.Length * 1.1, rectangle.Width);
            }
        }
    }
}
