using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _15ThreeSum
    {
        //Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

        //Note:

        //The solution set must not contain duplicate triplets.

        //Example:

        //Given array nums = [-1, 0, 1, 2, -1, -4],

        //A solution set is:
        //[
        //  [-1, 0, 1],
        //  [-1, -1, 2]
        //]
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            //sort the array first
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //remove the duplicated
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                var low = i + 1;
                var high = nums.Length - 1;
                var sum = 0 - nums[i];
                while (low < high)
                {
                    if (nums[low] + nums[high] == sum)
                    {
                        var newList = new List<int>();
                        newList.Add(nums[i]);
                        newList.Add(nums[low]);
                        newList.Add(nums[high]);
                        result.Add(newList);
                        while (low <high && nums[low] == nums[low + 1])
                        {
                            low++;
                        }
                        while (low < high && nums[high] == nums[high - 1])
                        {
                            high--;
                        }
                        low++;
                        high--;
                    }
                    else if(nums[low] + nums[high] < sum)
                    {
                        low++;
                    }
                    else
                    {
                        high--;
                    }
                }
            }

            return result;
        }

    }
}
