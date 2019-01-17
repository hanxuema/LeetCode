using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1TwoSum
    {
        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //Example:

        //Given nums = [2, 7, 11, 15], target = 9,

        //Because nums[0] + nums[1] = 2 + 7 = 9,
        //return [0, 1].
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[] { -1, -1 };

            //check corner case
            if (nums == null || nums.Length < 2)
            {
                return result;
            }
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                //if the dic has no such value, add it
                if (dic.ContainsKey(target - nums[i])) //dic has 2 and target - nums[i] is 7
                {
                    //find the value
                    result[0] = dic[target - nums[i]];
                    result[1] = i;
                    break;
                    
                }
                //else return
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            return result;
        }
    }
}