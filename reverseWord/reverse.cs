using System;

public class HelloWorld
{
    Helper(str word, str backwards) {
	    if (word == "") {
		    return backwards
	    } 
	    else { 
		    return Helper(word[:-1], word[-1] + backwards)
        }
    }

    ReverseWord(str word) { 
        return Helper(word, "")
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}