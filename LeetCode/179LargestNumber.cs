using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given a list of non negative integers, arrange them such that they form the largest number.

    //Example 1:

    //Input: [10,2]
    //    Output: "210"
    //Example 2:

    //Input: [3,30,34,5,9]
    //    Output: "9534330"
    //Note: The result may be very large, so you need to return a string instead of an integer.


    public class _179LargestNumber
    {
        public string LargestNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0) return "";

            Array.Sort(nums, (a, b) => string.Compare(b + "" + a, a + "" + b));
            return nums[0] == 0 ? "0" : string.Join("", nums);
        }
    }
}
