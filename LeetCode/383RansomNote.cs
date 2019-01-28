using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.

    //Each letter in the magazine string can only be used once in your ransom note.

    //Note:
    //You may assume that both strings contain only lowercase letters.

    //canConstruct("a", "b") -> false
    //canConstruct("aa", "ab") -> false
    //canConstruct("aa", "aab") -> true
    public class _383RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
       
            //convert string to dic
            var result = true;
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                if (!dic.ContainsKey(magazine[i])) dic.Add(magazine[i], 1);
                else dic[magazine[i]] = dic[magazine[i]] + 1;
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (dic.ContainsKey(ransomNote[i]))
                {
                    if (dic[ransomNote[i]] == 0) return false;
                    else dic[ransomNote[i]] = dic[ransomNote[i]] - 1;
                }
                else { return false; }
            }

            return result;
        }

        //can't return false if magazine is "", because if ransomNote is "", result should be true
    }
}

