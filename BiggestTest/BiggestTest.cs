namespace BiggestTest;

public class BiggestTest
{
    
    [Fact]
    public void TestWholeNums()
    {
        double[] a = {1,2,3,4,5};
        Assert.Equal(5, Biggest.GetBiggest(a));
    }
}
