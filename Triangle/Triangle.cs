using System;

public class Triangle
{
    public static string TriangleType(double a, double b, double c) {
        if (!(a+b>c) | !(a+c>b) | !(b+c>a) | !(a > 0) | !(b > 0)| !(c > 0)) {
            return "ERROR";
        }
        else if (a == b & b == c) {
            return "EQUILATERAL";
        } else if (a == b | b == c | a == c) {
            return "ISOSCLESE";
        } else if (c*c == a*a + b*b | a*a == b*b + c*c | b*b == a*a + c*c) {
            return "RIGHT";
        } else if (a != b && b != c) {
            return "SCALENE";
        } else {
            return "ERROR";
        }
    }
    
    public static void Main(string[] args)
    {
        //
    }
        
}
