using System;

public class HelloWorld
{
    Helper(arr nums, int big) {
	if nums == []
		return big //need to determine default val for big? null? 
	else 
		if num[0] > big { 
			return Helper(nums[1:], num[0])
		} else {
			return Helper(nums[1:], big)
		}
    }
    Biggest(arr nums) {
	    return Helper(arr nums, null)
    }

    Helper2 (arr nums, int big, int secondBig) {
	    if nums == [] { 
		    return (big, secondBig)
	    } else 
		    if num[0] > big {
			    return Helper2(nums[1:], num[0], big)
		    else {
			    return Helper2(nums[1:], big, secondBig)
		    }
        }
    }
    BiggestTwo(arr nums) {
        return Helper2(nums, null, null)
    } 

    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}