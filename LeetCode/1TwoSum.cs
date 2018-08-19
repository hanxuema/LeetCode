using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {

            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    result[1] = i;
                    result[0] = dict[target - nums[i]];
                    return result;
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return result;
        }
    }
} 