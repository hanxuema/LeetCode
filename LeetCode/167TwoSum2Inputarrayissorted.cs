﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _167TwoSum2Inputarrayissorted
    {
        //Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

        //The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.

        //Note:

        //Your returned answers (both index1 and index2) are not zero-based.
        //You may assume that each input would have exactly one solution and you may not use the same element twice.
        //Example:

        //Input: numbers = [2, 7, 11, 15], target = 9
        //Output: [1,2]
        //Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
        public int[] TwoSum(int[] numbers, int target)
        {
            var low = 0;
            var high = numbers.Length - 1;
            var result = new int[2];
            while (low < high)
            {
                if (numbers[low] + numbers[high] == target)
                {
                    result[0] = low + 1;
                    result[1] = high + 1;
                    return result;
                }
                else if (numbers[low] + numbers[high] > target)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }
            return result;
        }
    }
}
