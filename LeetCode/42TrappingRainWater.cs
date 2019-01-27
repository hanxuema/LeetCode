using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
    //The above elevation map is represented by array[0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]. In this case, 6 units of rain water (blue section) are being trapped. Thanks Marcos for contributing this image!

    //Example:


    //Input: [0,1,0,2,1,0,1,3,2,1,2,1]
    //Output: 6
    public class _42TrappingRainWater
    {
        public int Trap(int[] height)
        {
            if (height == null || height.Length < 2) return 0;

            var left = 0;
            var right = height.Length - 1;
            var leftMax = 0;
            var rightMax = 0;
            var result = 0;
            while (left < right)
            {
                leftMax = Math.Max(leftMax, height[left]);
                rightMax = Math.Max(rightMax, height[right]);
                if (leftMax < rightMax)
                {
                    result += leftMax - height[left];
                    left++;
                }
                else
                {
                    result += rightMax - height[right];
                    right--;
                }

            }
            return result;
        }
    }
}
