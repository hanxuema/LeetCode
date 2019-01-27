using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an unsorted array of integers, find the length of the longest consecutive elements sequence.

    //Your algorithm should run in O(n) complexity.

    //Example:

    //Input: [100, 4, 200, 1, 3, 2]
    //Output: 4
    //Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
    public class _128LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return nums.Length;

            var max = 0;
            var hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                hs.Add(nums[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hs.Contains(nums[i] - 1)) //find the low bound
                {
                    var curLength = 0;
                    var high = nums[i];
                    while (hs.Contains(high))
                    {
                        high++;
                        curLength++;
                    }

                    max = Math.Max(max, curLength);
                }
            }

            return max;
        }
    }
}
