using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class GaltonGoogle
    {
        public string ReturnWord(string sentence, string pattern)
        {
            //sentence - this is good open nice office walala gate iii
            //pattern - google
            var result = string.Empty;
            if (sentence.Length == 0 || pattern.Length == 0) return result;
            var sb = new StringBuilder();
            var sentenceArray = sentence.Split(' ');
            var i = 0;
            var k = 0;
            while (i < pattern.Length - 1 && k < sentenceArray.Length)
            {

                if (!sentenceArray[k].Contains(pattern[i]))
                {
                    sb.Append(sentenceArray[k] + " ");
                }
                else
                {
                    sb.Append(sentenceArray[k]);
                    sb.AppendLine();
                    if (i < pattern.Length - 1) i++;

                }
                if (k < sentenceArray.Length) k++;

            }


            return sb.ToString();
        }
    }
}
