using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _20ValidParentheses
    {
        //Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        //An input string is valid if:

        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.
        //Note that an empty string is also considered valid.

        //Example 1:

        //Input: "()"
        //Output: true
        //Example 2:

        //Input: "()[]{}"
        //Output: true
        //Example 3:

        //Input: "(]"
        //Output: false
        //Example 4:

        //Input: "([)]"
        //Output: false
        //Example 5:

        //Input: "{[]}"
        //Output: true

        public bool IsValid(string s)
        { 
            if (s ==null || s.Length == 0)
            {
                return true;
            }
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[')
                {
                    st.Push(']');
                }
                else if (s[i] == '{')
                {
                    st.Push('}');
                }
                else if (s[i] == '(')
                {
                    st.Push(')');
                }
                else
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }
                    if (st.Pop() != s[i])
                    {
                        return false;
                    }
                }
            }
            return st.Count == 0;
        }
    }
}
