using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
   public class _709ToLowerCase
    {
        //Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.

        //Example 1:
        //Input: "Hello"
        //Output: "hello"

        //Example 2:
        //Input: "here"
        //Output: "here"

        //Example 3:
        //Input: "LOVELY"
        //Output: "lovely"
        public string ToLowerCase(string str)
        {
           
            var hashSet = new Dictionary<char, char>();

            hashSet.Add('A', 'a');
            hashSet.Add('B', 'b');
            hashSet.Add('C', 'c');
            hashSet.Add('D', 'd');
            hashSet.Add('E', 'e');
            hashSet.Add('F', 'f');
            hashSet.Add('G', 'g');
            hashSet.Add('H', 'h');
            hashSet.Add('I', 'i');
            hashSet.Add('J', 'j');
            hashSet.Add('K', 'k');
            hashSet.Add('L', 'l');
            hashSet.Add('M', 'm');
            hashSet.Add('N', 'n');
            hashSet.Add('O', 'o');
            hashSet.Add('P', 'p');
            hashSet.Add('Q', 'q');
            hashSet.Add('R', 'r');
            hashSet.Add('S', 's');
            hashSet.Add('T', 't');
            hashSet.Add('U', 'u');
            hashSet.Add('V', 'v');
            hashSet.Add('W', 'w');
            hashSet.Add('X', 'x');
            hashSet.Add('Y', 'y');
            hashSet.Add('Z', 'z');

            var chararray = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                chararray[i] = hashSet.ContainsKey(str[i]) ?  hashSet[str[i]] : str[i];
            }

            return new string(chararray); 
        }
    }
}
