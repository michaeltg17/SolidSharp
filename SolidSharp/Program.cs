using SolidSharp.Models;

namespace SolidSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Violations codes to ease searching:
            //SRP Violation (Single responsability principle)
            //OCP Violation (Open/Closed principle)
            //LSP Violation (Liskov substitution principle)
            //ISP Violation (Interface segregation principle)
            //DIP Violation (Dependency inversion principle)

            var rectangle = new Rectangle(2, 4);
            var circle = new Circle(5);
            var square = new Square(4);

            var mutableRectangle = new MutableRectangle(2, 4);

            RectangleService.IncreaseAreaByTenPercent([square]);
        }
    }
}
