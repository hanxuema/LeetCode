using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _771JewelsandStones
    {
        //You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

        //The letters in J are guaranteed distinct, and all characters in J and S are letters.Letters are case sensitive, so "a" is considered a different type of stone from "A".

        //Example 1:
        //Input: J = "aA", S = "aAAbbbb"
        //Output: 3

        //Example 2:
        //Input: J = "z", S = "ZZ"
        //Output: 0
        //Note:

        //S and J will consist of letters and have length at most 50.
        //The characters in J are distinct.

        public int NumJewelsInStones(string J, string S)
        {
            var result = 0;

            var hash = new Dictionary<char, int>();
            for (int i = 0; i < S.Length; i++)
            {
                if (hash.ContainsKey(S[i]))
                {
                    hash[S[i]] = hash[S[i]] + 1;
                }
                else
                {
                    hash.Add(S[i], 1);
                }
            }
            for (int i = 0; i < J.Length; i++)
            {
                if (hash.ContainsKey(J[i]))
                {
                    result = result + hash[J[i]];
                }
            }
            return result;
        }

    }
}
