using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _283MoveZeroes
    {
        //Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        //Example:

        //Input: [0,1,0,3,12]
        //Output: [1,3,12,0,0]
        //Note:

        //[0,1,0,3,12]
        //[1,0,0,3,12]
        //[1,3,0,0,12]
        //[1,3,0,0,12]
        //[0,1,0,3,12]
        //[0,1,0,3,12]
        //[0,1,0,3,12]
        //[0,1,0,3,12]
        //You must do this in-place without making a copy of the array.
        //Minimize the total number of operations.
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length >= 2) if (nums == null || nums.Length <= 1)
                    return;

            int curr = 0;
            int next = 1;

            while (next <= nums.Length - 1)
            {
                if (nums[curr] == 0)
                {
                    if (nums[next] == 0)
                    {
                        next++;
                        continue;
                    }
                    else
                    {
                        nums[curr] = nums[next];
                        nums[next] = 0;
                    }
                }
                curr++;
                next++;
            }
        }
    }
}
