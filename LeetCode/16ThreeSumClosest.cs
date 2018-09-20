using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _16ThreeSumClosest
    {
        //Given an array nums of n integers and an integer target, find three integers in nums such that the sum is closest to target.Return the sum of the three integers.You may assume that each input would have exactly one solution.

        //Example:

        //Given array nums = [-1, 2, 1, -4], and target = 1.

        //The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

        public int ThreeSumClosest(int[] nums, int target)
        {
            var result = nums[0] + nums[1] + nums[nums.Length - 1];
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                var low = i + 1;
                var high = nums.Length - 1;

                while (low < high)
                {
                    int sum = nums[low] + nums[high] + nums[i];
                    if (sum > target)
                    {
                        high--;
                    }
                    else
                    {
                        low++;
                    }

                    if (Math.Abs(sum - target) < Math.Abs(result -  target))
                    {
                        result = sum;
                    }
                }
            }

            return result;
        }
    }
}
