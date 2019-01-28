using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Write a function that takes a string as input and reverse only the vowels of a string.

    //Example 1:

    //Input: "hello"
    //Output: "holle"
    //Example 2:

    //Input: "leetcode"
    //Output: "leotcede"
    //Note:
    //The vowels does not include the letter "y".


    public class _345ReverseVowelsofaString
    {
        public string ReverseVowels(string s)
        {
            if (s == null || s.Length < 2) return s;

            var left = 0;
            var right = s.Length - 1;
            var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var sb = s.ToCharArray();
            //2 pointer
            while (left < right)
            {
                if (vowels.Contains(sb[left]) && vowels.Contains(sb[right]))
                {
                    var temp = sb[left];
                    sb[left] = sb[right];
                    sb[right] = temp;
                    left++;
                    right--;
                }
                else if (vowels.Contains(sb[left]) && !vowels.Contains(sb[right]))
                {
                    right--;
                }
                else if (!vowels.Contains(sb[left]) && vowels.Contains(sb[right]))
                {
                    left++;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return new String(sb);
        }
    }
}
