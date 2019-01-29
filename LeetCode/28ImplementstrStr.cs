using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //    Implement strStr().

    //Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

    //Example 1:

    //Input: haystack = "hello", needle = "ll"
    //Output: 2
    //Example 2:

    //Input: haystack = "aaaaa", needle = "bba"
    //Output: -1
    //Clarification:

    //What should we return when needle is an empty string? This is a great question to ask during an interview.

    //For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().
    public class _28ImplementstrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;

            //hello
            //lu
            var result = -1;
            for (int i = 0; i < haystack.Length - needle.Length +1; i++)
            {
                if (haystack.Substring(i, needle.Length).Equals(needle)) return i;
            }

            return result;
        }
    }
}
