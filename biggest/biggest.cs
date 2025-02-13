using System;
using System.Linq;

public class Biggest
{
    public static double Helper(double[] nums, double big) {
        if (nums == null || nums.Length <= 1) {
            if (nums[0] > big) {
                return nums[0];
            } else {
            return big; //need to determine default val for big? null? 
            }
    } else {
            if (nums[0] > big) { 
                return Helper(nums[1..], nums[0]);
            } else {
                return Helper(nums[1..], big);
            }
        }
    }
    public static double GetBiggest(double[] nums) {
	    return Helper(nums, 0);
    }

    public static (double, double) Helper2(double[] nums, double big, double secondBig) {
	    if (nums == null || nums.Length <= 1) { 
		    return (big, secondBig);
	    } else {
		    if (nums[0] > big) {
			    return Helper2(nums[1..], nums[0], big);
            } else {
			    return Helper2(nums[1..], big, secondBig);
		    }
        }
    }
    public static (double, double) GetBiggestTwo(double[] nums) {
        return Helper2(nums, 0, 0);
    } 

     public static void Main(string[] args)
    {
        //
    }
}