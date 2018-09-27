using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _125ValidPalindrome
    {
        //Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

        //Note: For the purpose of this problem, we define empty string as valid palindrome.

        //Example 1:

        //Input: "A man, a plan, a canal: Panama"
        //Output: true
        //Example 2:

        //Input: "race a car"
        //Output: false
        public bool IsPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s)) { return true; }

            var result = true;
            var low = 0;
            var high = s.Length - 1;
            while (low < high)
            {
                while (low < s.Length - 1 && low < high && !char.IsLetterOrDigit(s[low]))
                {
                    low++;
                }
                while (high > 0 && low < high && !char.IsLetterOrDigit(s[high]))
                {
                    high--;
                }
                if (char.ToLower(s[low]) != char.ToLower(s[high]))
                {
                    return false;
                }

                low++;
                high--;
            }
            return result;
        }
    }
}
