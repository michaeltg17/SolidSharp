using FluentAssertions;
using SolidSharp.Models;
using Xunit;

namespace SolidSharp.Tests
{
    public class Tests
    {
        [Fact]
        public void LSPViolation()
        {
            //Given
            MutableRectangle rectangle = new MutableSquare(5);

            //When
            rectangle.Length = 15;
            rectangle.Width = 10;

            //Then
            rectangle.Area.Should().Be(150);

            //LSP Violation
            //We expect the rectangle to have area of 150 but has 100 because it's still a square, to avoid this:
            //1 - We make shapes immutable having to create a new one each time or
            //2 - We make the square not inherit the rectangle
        }
    }
}
