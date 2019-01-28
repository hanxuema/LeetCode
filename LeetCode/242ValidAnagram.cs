using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given two strings s and t, write a function to determine if t is an anagram of s.

    //Example 1:

    //Input: s = "anagram", t = "nagaram"
    //            nagaram
    //Output: true
    //Example 2:


    //Input: s = "rat", t = "car"
    //Output: false
    //Note:
    //You may assume the string contains only lowercase alphabets.

    //Follow up:
    //What if the inputs contain unicode characters? How would you adapt your solution to such case?
    public class _242ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == null || t == null || s.Length == 0 || t.Length == 0) return true;

            if (s.Length != t.Length) return false;
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i])) dic.Add(s[i], 1);
                else dic[s[i]] = dic[s[i]] + 1;
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (dic.ContainsKey(t[i]))
                {
                    if (dic[t[i]] == 0) return false;
                    else dic[t[i]] = dic[t[i]] - 1;
                }
                else return false;
            }
            return true;
        }
    }
}
