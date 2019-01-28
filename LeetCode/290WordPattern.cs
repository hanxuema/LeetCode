using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given a pattern and a string str, find if str follows the same pattern.

    //Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in str.

    //Example 1:

    //Input: pattern = "abba", str = "dog cat cat dog"
    //Output: true
    //Example 2:

    //Input:pattern = "abba", str = "dog cat cat fish"
    //Output: false
    //Example 3:

    //Input: pattern = "aaaa", str = "dog cat cat dog"
    //Output: false
    //Example 4:

    //Input: pattern = "abba", str = "dog dog dog dog"
    //Output: false
    //Notes:
    //You may assume pattern contains only lowercase letters, and str contains lowercase letters separated by a single space.
    public class _290WordPattern
    {
        public bool WordPattern(string pattern, string str)
        {
            if (pattern == null || str == null) return false;
            var strArr = str.Split(' ');
            if (strArr.Length != pattern.Length) return false;

            var dic = new Dictionary<char, string>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (dic.ContainsKey(pattern[i])){
                    if (dic[pattern[i]].Equals(strArr[i])) continue;
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (dic.ContainsValue(strArr[i]))
                    {
                        return false;
                    }
                    else
                    {
                        dic.Add(pattern[i], strArr[i]);
                    }
                }
            }

            return true;
        }
    }
}
