using SolidSharp.Models;

namespace SolidSharp.Services
{
    internal class RectangleService(IShapeService shapeService)
    {
        const int rectangleConstant = 100;

        public IEnumerable<Rectangle> IncreaseAreaByTenPercent(IEnumerable<Rectangle> rectangles)
        {
            foreach (var rectangle in rectangles)
            {
                yield return new Rectangle(rectangle.Length * 1.1, rectangle.Width);
            }
        }

        public double SumAreaPlusPerimeterPlusSpecificRectangleConstant(IEnumerable<Rectangle> rectangles)
        {
            //DIP Violation - Should be injected wiht interface in method or ideally in class for ease
            //on changing the implementation for testing or other purpose. Next method is the correct one.
            var shapeService = new ShapeService();
            return shapeService.SumPerimeter(rectangles) + shapeService.SumArea(rectangles) + rectangleConstant;
        }

        public double SumAreaPlusPerimeterPlusSpecificRectangleConstant2(IEnumerable<Rectangle> rectangles)
        {
            return shapeService.SumPerimeter(rectangles) + shapeService.SumArea(rectangles) + rectangleConstant;
        }
    }
}
