using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Write a function to find the longest common prefix string amongst an array of strings.

    //If there is no common prefix, return an empty string "".

    //Example 1:

    //Input: ["flower","flow","flight"]
    //Output: "fl"
    //Example 2:

    //Input: ["dog","racecar","car"]
    //Output: ""
    //Explanation: There is no common prefix among the input strings.
    //Note:

    //All given inputs are in lowercase letters a-z.
    public class _14LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length < 2) return "";
            if (strs.Length == 1) return strs[0];

            var result = new StringBuilder(strs[0]);
            for (int i = 1; i < strs.Length; i++)
            { 
                //make sure it compare with the result not the pre one
                var temp = result.ToString();
                var cur = strs[i];
                var shortLength = Math.Min(cur.Length, temp.Length);
                if (shortLength == 0) return "";

                result.Clear();
                for (int k = 0; k < shortLength; k++)
                {
                    if (cur[k] == temp.ToString()[k])
                    {
                        result.Append(cur[k]);
                    }
                    else break;
                }
            }
            return result.ToString();
        }
    }
}
