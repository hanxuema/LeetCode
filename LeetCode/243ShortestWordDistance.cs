using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given a list of words and two words word1 and word2, return the shortest distance between these two words in the list.

    //For example,
    //Assume that words = ["practice", "makes", "perfect", "coding", "makes"].

    //Given word1 = “coding”, word2 = “practice”, return 3.
    //Given word1 = "makes", word2 = "coding", return 1.
    public class _243ShortestWordDistance
    {
        public int shortestDistance(String[] words, String word1, String word2)
        {
            if (words.Length == 0 || string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
            {
                return 0;
            }

            var result = int.MaxValue;
            var w1i = -1;
            var w2i = -1;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(word1)) w1i = i;
                if (words[i].Equals(word2)) w2i = i;

                if (w1i >= 0 && w2i >= 0)
                {
                    result = Math.Min(result, Math.Abs(w1i - w2i));
                }
            }
            return result;
        }
    }
}
