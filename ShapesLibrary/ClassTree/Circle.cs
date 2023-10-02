namespace ShapesLibrary.ClassTree
{
    public class Circle : Shape
    {
        public readonly double Radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException(Constants.NegativeOrZeroNumberErrorMessage);

            Radius = radius;
        }

        public override double GetArea()
        {
            return double.Pi * Radius * Radius;
        }
    }
}
