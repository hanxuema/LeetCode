using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
   public class _344ReverseString
    {
        public string ReverseString(string s)
        {
            var result = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                result[s.Length - i - 1] = s[i];
            }
            return new String(result);
        }
    }
}
