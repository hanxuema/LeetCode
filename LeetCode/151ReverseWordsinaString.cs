using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an input string, reverse the string word by word.

    //Example:  

    //Input: "the sky is blue",
    //Output: "blue is sky the".
    //Note:

    //A word is defined as a sequence of non-space characters.
    //Input string may contain leading or trailing spaces.However, your reversed string should not contain leading or trailing spaces.
    //You need to reduce multiple spaces between two words to a single space in the reversed string.
    //Follow up: For C programmers, try to solve it in-place in O(1) space.


    public class _151ReverseWordsinaString
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length <= 1) return s.Trim();

            var temp = s.Split(' ');
            var sb = new StringBuilder();
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                if (temp[i] != "")
                {
                    sb.Append(temp[i].Trim());
                    if (i > 0) sb.Append(" ");
                }
            }

            return sb.ToString().Trim();
        }
    }
}
