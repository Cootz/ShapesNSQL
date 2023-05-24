using ShapesLib.Exceptions;

namespace ShapesLib.Tests
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = Math.PI)]
        [TestCase(8, ExpectedResult = 64d * Math.PI)]
        [TestCase(32, ExpectedResult = 1024d * Math.PI)]
        public double GetAreaPositiveTest(double radius) => new Circle(radius).GetArea();

        [Test]
        [TestCase(-1)]
        [TestCase(-0.01)]
        [TestCase(double.NegativeInfinity)]
        public void GetAreaNegativeTest(double radius) => Assert.Throws<NegativeArgumentException> ( () => new Circle(radius).GetArea());

        //P.S I didn't use AAA pattern here as these tests are pretty simple, need to mention that I know it
    }
}
