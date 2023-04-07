using System;
using Shape;

namespace ShapeUnitTests;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void Area_ValidTriangle_CalculatesArea()
    {
        var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };
        var area = triangle.Area();
        Assert.That(area, Is.EqualTo(6).Within(1e-12));
    }

    [Test]
    public void IsValid_ValidTriangle_ReturnsTrue()
    {
        var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };
        Assert.That(triangle.IsValid(), Is.True);
    }

    [Test]
    public void IsValid_InvalidTriangle_ReturnsFalse()
    {
        var triangle = new Triangle { SideA = 1, SideB = 2, SideC = 4 };
        Assert.That(triangle.IsValid(), Is.False);
    }

    [Test]
    public void IsRight_RightTriangle_ReturnsTrue()
    {
        var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };
        Assert.That(triangle.IsRight(), Is.True);
    }

    [Test]
    public void IsRight_NonRightTriangle_ReturnsFalse()
    {
        var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 6 };
        Assert.That(triangle.IsRight(), Is.False);
    }
}
