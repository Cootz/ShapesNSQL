namespace ShapesLib;

public abstract class Shape
{
    /// <summary>
    /// Calculates area of the <see cref="Shape"/>
    /// </summary>
    public abstract double GetArea();
}

//P.S I don't know if it's feasible here, since this class describes only one method and can be easily replaced with an interface