
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

    [Fact]
    public void Empty()
    {
        Assert.Equal("    ", Reverse.ReverseWord("    "));
    }

    [Fact]
    public void Palindrome()
    {
        //Palindrome - words that are spelt the same backwards and forwards
        Assert.Equal("racecar", Reverse.ReverseWord("racecar"));
    }

    [Fact]
    public void Punctuation()
    {
        Assert.Equal("!.,()#", Reverse.ReverseWord("#)(,.!"));
    }
}
