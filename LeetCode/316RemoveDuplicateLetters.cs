using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given a string which contains only lowercase letters, remove duplicate letters so that every letter appear once and only once.You must make sure your result is the smallest in lexicographical order among all possible results.

    //Example 1:
    //Input: "bcabc"
    //Output: "abc"

    //Example 2:
    //Input: "cbacdcbc"
    //Output: "acdb"
    public class _316RemoveDuplicateLetters
    {
        public string RemoveDuplicateLetters(string s)
        {
            if (String.IsNullOrEmpty(s) || s.Length == 1) return s;

            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count == 0) stack.Push(s[i]);
                else
                {
                    if (!stack.Contains(s[i]))
                    {
                        if (stack.Peek() > s[i])
                        {
                            
                        }
                    }
                }
            }

            var res = new char[stack.Count];
            var index = 0;
            while (stack.Count > 0)
            {
                res[index] = stack.Pop();
                index++;
            }
            Array.Reverse(res);
            //Array.Sort(res);
            return new string(res);
        }
    }
}
