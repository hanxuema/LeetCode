using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _7ReverseInteger
    {
        //Given a 32-bit signed integer, reverse digits of an integer.

        //Example 1:
        //Input: 123
        //Output: 321

        //Example 2: 
        //Input: -123
        //Output: -321

        //Example 3: 
        //Input: 120
        //Output: 21

        //Note:
        //Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

        public int Reverse(int x)
        {
            if (x <= Int32.MinValue || x > Int32.MaxValue)
            {
                return 0;
            }

            var isNegative = x < 0;
            long result = 0;
            var index = 1;
            if (isNegative)
            {
                x = 0 - x;
            }
            do
            {
                var temp = x % 10;
                result = result * 10 * 1 + temp;
                x = x / 10;

                index++;
            } while (x > 0);

            if (result < Int32.MinValue || result > Int32.MaxValue)
            {
                return 0;
            }
            return isNegative ? 0 - (int)result : (int)result;
        }
    }
}
