using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an array of strings, group anagrams together.

    //Example:

    //Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
    //Output:
    //[
    //  ["ate","eat","tea"],
    //  ["nat","tan"],
    //  ["bat"]
    //]
    //Note:

    //All inputs will be in lowercase.
    //The order of your output does not matter.
    public class _49GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var res = new List<IList<string>>();
            if (strs == null || strs.Length == 0) return res;

            var dic = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                var cur = strs[i].ToCharArray();
                Array.Sort(cur); //turn ate eat tea all to aet
                if (dic.ContainsKey(new string(cur)))
                {
                    var list = dic[new string(cur)];
                    list.Add(strs[i]);
                }
                else
                {
                    var newList = new List<string>();
                    newList.Add(strs[i]);
                    dic.Add(new string(cur), newList);
                    res.Add(newList);
                }
            }
            return res;

        }
    }
}
