using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given two strings s and t, determine if they are isomorphic.

    //Two strings are isomorphic if the characters in s can be replaced to get t.

    //All occurrences of a character must be replaced with another character while preserving the order of characters.No two characters may map to the same character but a character may map to itself.

    //Example 1:

    //Input: s = "egg", t = "add"
    //Output: true
    //Example 2:


    //Input: s = "foo", t = "bar"
    //Output: false
    //Example 3:


    //Input: s = "paper", t = "title"
    //Output: true
    //Note:
    //You may assume both s and t have the same length.
    public class _205IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s == null || t == null) return false;
             
            //map char from s to char from t
            var dic = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    if (dic[s[i]] == t[i]) continue; //abc efg
                    else return false; //aac efg
                }
                else
                {
                    if (!dic.ContainsValue(t[i]))
                    {
                        dic.Add(s[i], t[i]); //abc eft
                    } //new pattern
                    else return false; //ab aa
                }
            }

            return true;
        }

        //need to consider all the senarios
    }
}
