using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
   public class _561ArrayPartitionI
    {
        public int ArrayPairSum(int[] nums)
        {
            var result = 0;
            //sort first
             Array.Sort(nums);
            //and take every 2 pair
            for (int i = 0; i < nums.Count(); i+=2)
            {
                result = result + nums[i];
            }
            return result;
        }
    }
}
