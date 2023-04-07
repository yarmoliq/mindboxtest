using Shape;

IShape shape;
if (string.IsNullOrEmpty(Console.ReadLine()))
{
    shape = new Circle
    {
        Radius = 5
    };
}
else
{
    shape = new Triangle
    {
        SideA = 3,
        SideB = 4,
        SideC = 5
    };
}

Console.WriteLine(shape.Area());
