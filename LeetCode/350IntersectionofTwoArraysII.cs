﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _350IntersectionofTwoArraysII
    {
        //Given two arrays, write a function to compute their intersection.

        //Example 1:
        //Input: nums1 = [1,2,2,1], nums2 = [2,2]
        //Output: [2,2]

        //Example 2:
        //Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        //Output: [4,9]

        //Note:

        //Each element in the result should appear as many times as it shows in both arrays.
        //The result can be in any order.
        //Follow up:

        //What if the given array is already sorted? How would you optimize your algorithm?
        //What if nums1's size is small compared to nums2's size? Which algorithm is better?
        //What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var result = new List<int>();
            //sort both array
            Array.Sort(nums1);
            Array.Sort(nums2);
            //set 2 points for each array
            var p1 = 0;
            var p2 = 0;

            //loop both array
            while (p1 < nums1.Length  && p2 < nums2.Length )
            {
                if (nums1[p1] == nums2[p2])
                {
                    result.Add(nums1[p1]);
                    p1++;
                    p2++;
                }
                else if (nums1[p1] < nums2[p2])
                {
                    p1++;
                }
                else
                {
                    p2++;
                }
            }

            return result.ToArray();
        }
    }
}
