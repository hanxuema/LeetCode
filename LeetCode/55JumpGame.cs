using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an array of non-negative integers, you are initially positioned at the first index of the array.

    //Each element in the array represents your maximum jump length at that position.

    //Determine if you are able to reach the last index.

    //Example 1:

    //Input: [2,3,1,1,4]
    //Output: true
    //Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
    //Example 2:

    //Input: [3,2,1,0,4]
    //Output: false
    //Explanation: You will always arrive at index 3 no matter what.Its maximum
    //jump length is 0, which makes it impossible to reach the last index.

    public class _55JumpGame
    {
        public bool CanJump(int[] nums)
        {
            //if there is only 1 item in the array
            if (nums.Length < 2) return true;
            //define the maxReach on a index
            var maxReach = 0;
            for (int i = 0; i < nums.Length && i <= maxReach; i++)
            {
                maxReach = Math.Max(maxReach, nums[i] + i);//find the current index plus steps that it can go 
                if (maxReach >= nums.Length - 1) return true;
            }
            return false;
        }
    }
}
