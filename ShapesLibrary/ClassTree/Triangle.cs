namespace ShapesLibrary.ClassTree
{
    public class Triangle : Shape
    {
        public readonly double Side1;
        public readonly double Side2;
        public readonly double Side3;

        public readonly bool RightAngled;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException(Constants.NegativeOrZeroNumberErrorMessage);

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

            RightAngled = isRightAngled();
        }

        public override double GetArea()
        {
            var semiPerimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
        }

        private bool isRightAngled()
        {
            return Side1 * Side1 + Side2 * Side2 == Side3 * Side3
                || Side1 * Side1 + Side3 * Side3 == Side2 * Side2
                || Side2 * Side2 + Side3 * Side3 == Side1 * Side1;


        }
    }
}
