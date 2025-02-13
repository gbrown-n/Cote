namespace BiggestTest;

public class BiggestTest
{
    
    [Fact]
    public void TestWholeNums()
    {
        double[] a = {1,2,3,4,5};
        Assert.Equal(5, Biggest.GetBiggest(a));
    }
    [Fact]
    public void Dupes()
    {
        double[] a = {1,2,3,3,4,5};
        Assert.Equal(5,Biggest.GetBiggest(a));
    }

    [Fact]
    public void DupeBiggest()
    {
        double[] a = {1,2,3,4,5,5};
        Assert.Equal(5, Biggest.GetBiggest(a));
    }

    [Fact]
    public void DupeTwoBiggest()
    {
        double[] a = {1,2,3,4,5,5};
        Assert.Equal((5,4), Biggest.GetBiggestTwo(a));
    }

    [Fact]
    public void Empty()
    {
        double[] a = {};
        Assert.Equal(0,Biggest.GetBiggest(a));
        Assert.Equal((0,0),Biggest.GetBiggestTwo(a));
    }

    [Fact]
    public void Decimals()
    {
        double[] a = {1.1, 1.2, 1.3, 1.4, 1.5};
        Assert.Equal(1.5, Biggest.GetBiggest(a));
        Assert.Equal((1.5,1.4), Biggest.GetBiggestTwo(a));
    }
}
