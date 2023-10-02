using ShapesLibrary.ClassTree;

namespace ShapesLibraryTests
{
    public class TriangleTests
    {
        [Test]
        public void CheckNegativeSideTriangleThrowsEx()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-10, 3, 9));
        }

        [TestCase(5, 6, 5, ExpectedResult = 12)]
        [TestCase(3, 4, 5, ExpectedResult = 6)]
        public double CheckTriangleArea(double side1, double side2, double side3)
        {
            Shape triangle;
            triangle = new Triangle(side1, side2, side3);   // specific type of figure determines in run-time
            return triangle.GetArea();
        }

        [Test]
        public void CheckIsRightAngledReturnTrue()
        {
            Shape triangle;
            triangle = new Triangle(3, 4, 5);   // specific type of figure determines in run-time

            Assert.That((triangle as Triangle).RightAngled, Is.True);
        }
    }
}