namespace TriangleTest;

public class TriangleTest
{
    [Fact]
    public void ISOSCLESE()
    {
        Assert.Equal("ISOSCLESE", Triangle.TriangleType(2,2,3));
        Assert.Equal("ISOSCLESE", Triangle.TriangleType(3,2,2));
        Assert.Equal("ISOSCLESE", Triangle.TriangleType(2,3,2));
    }

    [Fact]
    public void RIGHT()
    {
        Assert.Equal("RIGHT", Triangle.TriangleType(3,4,5));
        Assert.Equal("RIGHT", Triangle.TriangleType(4,3,5));
        Assert.Equal("RIGHT", Triangle.TriangleType(5,4,3));
    }

    [Fact]
    public void EQUILATERAL()
    {
        Assert.Equal("EQUILATERAL", Triangle.TriangleType(1,1,1));
    }

    [Fact]
    public void SCALENE() 
    {
        Assert.Equal("SCALENE", Triangle.TriangleType(8,5,9));
        Assert.Equal("SCALENE", Triangle.TriangleType(9,8,5));
        Assert.Equal("SCALENE", Triangle.TriangleType(5,8,9));
    }
    [Fact]
    public void INEQUALITY()
    {
        Assert.Equal("ERROR", Triangle.TriangleType(1,1,20));
        Assert.Equal("ERROR", Triangle.TriangleType(20,1,1));
        Assert.Equal("ERROR", Triangle.TriangleType(20,1,1));
    }
    [Fact]
    public void NEGATIVE()
    {
        Assert.Equal("ERROR", Triangle.TriangleType(-1,1,1));
        Assert.Equal("ERROR", Triangle.TriangleType(1,-1,1));
        Assert.Equal("ERROR", Triangle.TriangleType(1,1,-1));
        
    }
    [Fact]
        public void ZERO()
    {
        Assert.Equal("ERROR", Triangle.TriangleType(0,1,1));
        Assert.Equal("ERROR", Triangle.TriangleType(1,0,1));
        Assert.Equal("ERROR", Triangle.TriangleType(1,1,0));
        
    }
}
