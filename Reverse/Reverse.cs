using System;
using System.Linq;

public class Reverse
{
    //TEST 2 - REVERSE WORD//
     public static string ReverseWordHelper(string word, string back) {
        //Console.WriteLine(word);
        if (word == "") {
            return back;
        } else {
            return ReverseWordHelper(word.Substring(0,word.Length - 1), back + word.Substring(word.Length - 1));
        }
    }
    
    public static string ReverseWord(string word) {
        return ReverseWordHelper(word, "");
    }

     public static void Main(string[] args)
    {
        //
    }
}
