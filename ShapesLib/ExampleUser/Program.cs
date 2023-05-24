//This is an example *user* of the ShapesLib

using ShapesLib;

Console.WriteLine("Calculating area of shape without knowing it's type");

List<Shape> pageShapes = new()
{
    new Circle(4),
    new Circle(16),
    new Triangle(3,4,5),
    new Triangle(16, 19, 22)
};

foreach (var shape in pageShapes)
{
    Console.WriteLine("Figure of area {0:N2}", shape.GetArea());
}

Console.WriteLine();
Console.WriteLine("Searching for right triangle");

var triangles = from shape in pageShapes where shape is Triangle triangle select (Triangle)shape;

int rightTrianglesCount = triangles.Count(t =>
{
    try
    {
        return t.AngleType == Triangle.AngleTypes.Right;
    }
    catch
    {
        return false;
    }
});

Console.WriteLine("Found {0} right triangle{1}", rightTrianglesCount, rightTrianglesCount > 1 ? "s" : string.Empty);
