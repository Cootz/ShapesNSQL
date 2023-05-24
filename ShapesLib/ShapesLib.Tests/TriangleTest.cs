namespace ShapesLib.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        [TestCase(0, 0, 0)]
        public double GetAreaPositiveTest(double a, double b, double c) => new Triangle(a,b,c).GetArea();

    }
}
