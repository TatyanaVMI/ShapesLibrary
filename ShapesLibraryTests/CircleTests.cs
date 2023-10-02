using ShapesLibrary.ClassTree;

namespace ShapesLibraryTests
{
    public class CircleTests
    {
        [Test]
        public void CheckNegativeRadiusThrowsEx()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-10));
        }

        [TestCase(10, ExpectedResult = 314)]
        [TestCase(4.6, ExpectedResult = 66)]
        public double CheckCircleArea(double radius)
        {
            Shape circle;
            circle = new Circle(radius);   // specific type of figure determines in run-time
            return Math.Round(circle.GetArea());
        }
    }
}