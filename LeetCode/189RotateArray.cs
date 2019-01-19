using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an array, rotate the array to the right by k steps, where k is non-negative.

    //Example 1:

    //Input: [1,2,3,4,5,6,7]
    //    and k = 3
    //Output: [5,6,7,1,2,3,4]
    //    Explanation:
    //rotate 1 steps to the right: [7,1,2,3,4,5,6]
    //    rotate 2 steps to the right: [6,7,1,2,3,4,5]
    //    rotate 3 steps to the right: [5,6,7,1,2,3,4]
    //    Example 2:

    //Input: [-1,-100,3,99]
    //    and k = 2
    //Output: [3,99,-1,-100]
    //    Explanation: 
    //rotate 1 steps to the right: [99,-1,-100,3]
    //    rotate 2 steps to the right: [3,99,-1,-100]
    //    Note:

    //Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
    //Could you do it in-place with O(1) extra space?
    public class _189RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums == null )
            {
                return;
            }
            k = k % nums.Length;
            //corner case
            if (nums.Length != k) //no need to rotate
            {
                for (int f = 0; f < k; f++)
                {
                    var toReplace = nums[nums.Length - 1];
                    for (int i = 0; i < nums.Length; i++)
                    {
                        var temp = nums[i];
                        nums[i] = toReplace;
                        toReplace = temp;
                    }
                }
            }
        }
    }
}
