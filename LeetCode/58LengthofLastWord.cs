using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

    //If the last word does not exist, return 0.

    //Note: A word is defined as a character sequence consists of non-space characters only.

    //Example:

    //Input: "Hello World"
    //Output: 5
    public class _58LengthofLastWord
    {
        
        public int LengthOfLastWord(string s)
        {
            if (s == null || s.Length == 0) return 0;
            var res = 0;
            s = s.Trim();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' || s.Length == res) break;
                else res++;
            }
            return res;
        }
    }

    //first run failed at "a " and " a", solution is to add trim
}
