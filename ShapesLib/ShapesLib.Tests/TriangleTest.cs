namespace ShapesLib.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        [TestCase(3, 4, 5, ExpectedResult = 6)]
        [TestCase(24, 32, 40, ExpectedResult = 384)]
        public double GetAreaPositiveTest(double a, double b, double c) => new Triangle(a,b,c).GetArea();

        [TestCase(0,1,0)]
        [TestCase(1,4,5)]
        [TestCase(200, 4, 5)]
        public void GetAreaNegativeTest(double a, double b, double c) => Assert.Throws<Exception>(() => new Triangle(a, b, c).GetArea());


        //Notice: Easily extendable when other angle types are implemented 
        [TestCase(3, 4, 5, ExpectedResult = Triangle.AngleTypes.Right)]
        [TestCase(5, 4, 3, ExpectedResult = Triangle.AngleTypes.Right)]
        [TestCase(5, 3, 4, ExpectedResult = Triangle.AngleTypes.Right)]
        public Triangle.AngleTypes AngleTypeTest(double a, double b, double c) => new Triangle(a, b, c).AngleType;
    }
}
