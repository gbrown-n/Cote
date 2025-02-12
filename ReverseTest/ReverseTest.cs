
namespace ReverseTest;

public class ReverseTest
{
    [Fact]
    public void TestHelloWorld()
    {
       Assert.Equal("!dlroWolleH",Reverse.ReverseWord("HelloWorld!")); 
    }

    [Fact]
    public void TestSpaces() 
    {
        Assert.Equal("a b c d e f g", Reverse.ReverseWord("g f e d c b a"));
    }
}
