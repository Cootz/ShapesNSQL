using ShapesLib.Exceptions;

namespace ShapesLib;

public class Triangle : Shape
{
    private double a,b,c;

    public double A
    {
        get => a;
        set
        {
            if (value < 0)
                throw new NegativeArgumentException();

            a = value;
        }
    }

    public double B
    {
        get => b;
        set
        {
            if (value < 0)
                throw new NegativeArgumentException();

            b = value;
        }
    }

    public double C
    {
        get => c;
        set
        {
            if (value < 0)
                throw new NegativeArgumentException();

            c = value;
        }
    }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double GetArea()
    {
        if (!CalculationHelper.DoesTriangleExist(A, B, C))
            throw new Exception("Triangle does not exist");

        return Math.Sqrt((A + B + C) * (-A + B + C) * (A - B + C) * (A + B - C)) / 4;
    }

    private static class CalculationHelper
    {
        public static bool DoesTriangleExist(double a, double b, double c)
        {
            double[] sides = { a, b, c };

            double twoLargestSidesSum = sides.OrderDescending().Take(2).Sum();

            return twoLargestSidesSum > sides.Min();
        }
    }
}