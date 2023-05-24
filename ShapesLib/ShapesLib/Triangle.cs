using ShapesLib.Exceptions;
// ReSharper disable CompareOfFloatsByEqualityOperator

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

    public AngleTypes AngleType
    {
        get => MathHelper.GetAngleType(this);
    }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double GetArea()
    {
        if (!MathHelper.DoesTriangleExist(this))
            throw new Exception("Triangle does not exist");

        return Math.Sqrt((A + B + C) * (-A + B + C) * (A - B + C) * (A + B - C)) / 4;
    }

    /// <summary>
    /// Help with math of <see cref="Triangle"/>
    /// </summary>
    private static class MathHelper
    {
        public static bool DoesTriangleExist(Triangle triangle)
        {
            double a = triangle.A;
            double b = triangle.B;
            double c = triangle.C;

            bool result = true;

            result &= a + b > c;
            result &= a + c > b;
            result &= b + c > a;

            return result;
        }

        public static AngleTypes GetAngleType(Triangle triangle)
        {
            if (isRightTriangle(triangle))
                return AngleTypes.Right;

            //P.S Does not implemented, yet it very flexible and can be easily extended
            throw new NotImplementedException(); 
        }

        private static bool isRightTriangle(Triangle triangle)
        {
            double ab = Math.Pow(triangle.A * triangle.B, 2);
            double ac = Math.Pow(triangle.A * triangle.C, 2);
            double bc = Math.Pow(triangle.B * triangle.C, 2);

            bool result = false;

            result |= ab + bc == ac;
            result |= ab + ac == bc;
            result |= bc + ac == ab;

            return result;
        }
    }

    public enum AngleTypes
    {
        /// <summary>
        /// Have three angles &lt; 90
        /// </summary>
        Acute,

        /// <summary>
        /// Have one angle = 90
        /// </summary>
        Right,
        
        /// <summary>
        /// Have one angle > 90
        /// </summary>
        Obtuse
    }
}