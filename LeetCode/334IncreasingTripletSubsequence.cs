using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an unsorted array return whether an increasing subsequence of length 3 exists or not in the array.

    //Formally the function should:

    //Return true if there exists i, j, k
    //such that arr[i] < arr[j] < arr[k] given 0 ≤ i<j<k ≤ n-1 else return false.
    //Note: Your algorithm should run in O(n) time complexity and O(1) space complexity.

    //Example 1:

    //Input: [1,2,3,4,5]
    //Output: true
    //Example 2:

    //Input: [5,4,3,2,1]
    //Output: false
    public class _334IncreasingTripletSubsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            //check corner case
            if (nums == null || nums.Length < 3) return false;

            var result = false;
            var min1 = int.MaxValue;
            var min2 = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                if (cur < min1)
                {
                    min1 = cur;
                }
                else if (cur > min1 && cur < min2)
                {
                    min2 = cur;
                }
                else if (cur > min2)
                {
                    return true;
                }
            }

            return result;
        }
    }
}
