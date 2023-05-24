using ShapesLib.Exceptions;

namespace ShapesLib;

public class Circle : Shape
{
    public double Radius
    {
        get => radius;
        set
        {
            if (value < 0)
                throw new NegativeArgumentException();

            radius = value;
        }
    }

    private double radius;

    public Circle(double radius) => Radius = radius;

    public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
}