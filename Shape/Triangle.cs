namespace Shape;

public class Triangle : Shape
{
    // If it was a more complex library, we would probably also have coordinates,
    // and we would've created a 'Polygon' class with 'Sides' array
    // and derive our triangle from that instead of doing 3 properties for each side
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
    
    // If it was a real library, we would've probably had a setting
    // weather to check if the triangle is valid before calculating
    // its area and throw exception if it is not
    public override double Area()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsValid()
    {
        return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
    }

    public bool IsRight()
    {
        return Math.Abs(SideA * SideA + SideB * SideB - SideC * SideC) < double.Epsilon
               || Math.Abs(SideA * SideA + SideC * SideC - SideB * SideB) < double.Epsilon
               || Math.Abs(SideB * SideB + SideC * SideC - SideA * SideA) < double.Epsilon;
    }
}
