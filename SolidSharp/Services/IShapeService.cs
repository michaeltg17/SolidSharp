using SolidSharp.Models;

namespace SolidSharp.Services
{
    internal interface IShapeService
    {
        double SumArea(IEnumerable<Shape> shapes);
        double SumPerimeter(IEnumerable<Shape> shapes);
    }
}
