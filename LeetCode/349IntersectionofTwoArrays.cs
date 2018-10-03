using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _349IntersectionofTwoArrays
    {
        //Given two arrays, write a function to compute their intersection.

        //Example 1:

        //Input: nums1 = [1,2,2,1], nums2 = [2,2]
        //Output: [2]
        //Example 2:

        //Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        //Output: [9,4]
        //Note:

        //Each element in the result must be unique.
        //The result can be in any order.

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            HashSet<int> set = new HashSet<int>();

            // Add the num1 in the hash set
            for (int i = 0; i < nums1.Length; i++)
            {
                set.Add(nums1[i]);
            }

            // Compare the num2 with the hash set
            for (int i = 0; i < nums2.Length; i++)
            {
                // Check if the set contains the element of num2
                if (set.Contains(nums2[i]))
                {
                    if (!result.Contains(nums2[i])) // only add if the result does not contains the num2 value
                    {
                        result.Add(nums2[i]);
                    }
                }
            }

            // Return the result in array
            return result.ToArray();
        }
    }
}
