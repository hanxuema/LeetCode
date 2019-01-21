using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an array of integers, find if the array contains any duplicates.

    //Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.

    //Example 1:
    //Input: [1,2,3,1]
    //    Output: true

    //Example 2:
    //Input: [1,2,3,4]
    //    Output: false

    //Example 3:
    //Input: [1,1,1,3,3,4,3,2,4,2]
    //    Output: true

    public class _217ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {

            //check corner case
            if (nums == null || nums.Length <= 1) return false;
            //loop
            var result = false;
            var hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hs.Contains(nums[i]))
                {
                    hs.Add(nums[i]);
                }
                else
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
