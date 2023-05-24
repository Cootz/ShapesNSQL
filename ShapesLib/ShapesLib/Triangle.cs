using ShapesLib.Exceptions;

namespace ShapesLib;

public class Triangle : Shape
{
    private double a, b, c;

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

    public override double GetArea() => Math.Sqrt((a + b + c) * (-a + b + c) * (a - b + c) * (a + b - c)) / 4;
}