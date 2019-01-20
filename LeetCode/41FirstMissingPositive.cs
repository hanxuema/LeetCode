using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an unsorted integer array, find the smallest missing positive integer.

    //Example 1:
    //Input: [1,2,0]
    //Output: 3

    //Example 2:
    //Input: [3,4,-1,1]
    //Output: 2

    //Example 3:
    //Input: [7,8,9,11,12]
    //Output: 1

    //Note:

    //Your algorithm should run in O(n) time and uses constant extra space.
    public class _41FirstMissingPositive
    {
        public int FirstMissingPositive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 1;
            }

            //make all the items that less than 0 to be the max
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0)
                {
                    nums[i] = int.MaxValue;
                }
            }

            //
            for (int i = 0; i < nums.Length; i++)
            {
                int num = Math.Abs(nums[i]);
                if (num <= nums.Length)
                {
                    nums[num - 1] = -Math.Abs(nums[num - 1]);
                }
            }

            
            //return the index of first non-zero value
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    return i + 1;
                }
            }

            return nums.Length + 1;
        }
    } 
}
