namespace TriangleTest;

public class TriangleTest
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("ISOSCLESE", Triangle.TriangleType(2,2,3));
    }
}
