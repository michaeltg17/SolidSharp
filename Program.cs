using SolidSharp.Models;

namespace SolidSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(2, 4);
            var circle = new Circle(5);
            var square = new Square(4);

            RectangleService.IncreaseAreaByTenPercent([square]);
        }
    }
}
