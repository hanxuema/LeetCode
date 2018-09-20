using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _18FourSum
    {
        //Given an array nums of n integers and an integer target, are there elements a, b, c, and d in nums such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.

        //Note:

        //The solution set must not contain duplicate quadruplets.

        //Example:

        //Given array nums = [1, 0, -1, 0, -2, 2], and target = 0.

        //A solution set is:
        //[
        //  [-1,  0, 0, 1],
        //  [-2, -1, 1, 2],
        //  [-2,  0, 0, 2]
        //]

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 4)
            {
                return result;
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                    var low = j + 1;
                    var high = nums.Length - 1;
                    while (low < high)
                    {
                        var sum = nums[i] + nums[j] + nums[low] + nums[high];
                        if (sum == target)
                        {
                            var newArray = new List<int>();
                            newArray.Add(nums[i]);
                            newArray.Add(nums[j]);
                            newArray.Add(nums[low]);
                            newArray.Add(nums[high]); 
                            result.Add(newArray);
                            while (low < high && nums[low] == nums[low + 1])
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
                        else if (sum < target)
                        {
                            low++;
                        }
                        else
                        {
                            high--;
                        }
                    }

                }

            }
            return result;
        }
    }
}
