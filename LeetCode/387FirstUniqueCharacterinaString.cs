using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

    //Examples:

    //s = "leetcode"
    //return 0.

    //s = "loveleetcode",
    //return 2.
    //Note: You may assume the string contain only lowercase letters.
    public class _387FirstUniqueCharacterinaString
    {
        public int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 0) return -1;
            var result = -1;
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))  dic[s[i]] = int.MinValue;
                else dic.Add(s[i], i);
            }
            foreach (var item in dic)
            {
                if (item.Value > int.MinValue) return item.Value;
            }
            
            return result;
        }
    }
}
