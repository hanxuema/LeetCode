using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _9PalindromeNumber
    {
        //Determine whether an integer is a palindrome.An integer is a palindrome when it reads the same backward as forward.

        //Example 1:

        //Input: 121
        //Output: true
        //Example 2:

        //Input: -121
        //Output: false
        //Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        //Example 3:

        //Input: 10
        //Output: false
        //Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
        //Follow up:

        //Coud you solve it without converting the integer to a string?
        public bool IsPalindrome(int x)
        {
            var ori = x;
            if (x < 0)
            {
                return false;
            }
            var temp = 0;
            while (x > 0)
            {
                temp = temp * 10 + x % 10;
                x = x / 10;
            }

            return ori == temp;
        }
    }
}
