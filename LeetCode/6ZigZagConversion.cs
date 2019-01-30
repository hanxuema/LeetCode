using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

    //P   A   H   N
    //A P L S I I G
    //Y   I   R
    //And then read line by line: "PAHNAPLSIIGYIR"

    //Write the code that will take a string and make this conversion given a number of rows:

    //string convert(string s, int numRows);
    //    Example 1:

    //Input: s = "PAYPALISHIRING", numRows = 3
    //Output: "PAHNAPLSIIGYIR"
    //Example 2:

    //Input: s = "PAYPALISHIRING", numRows = 4
    //Output: "PINALSIGYAHRPI"
    //Explanation:

    //P     I     N     0
    //A   L S   I G     1
    //Y A   H R         2
    //P     I           3
    public class _6ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows <= 1) return s;
            StringBuilder[] sb = new StringBuilder[numRows];
            for (int i = 0; i < sb.Length; i++) sb[i] = new StringBuilder();
            int dir = 1; //go down is 1 go up is -1
            int index = 0;
            //foreach (var c in s.ToCharArray())
            //{
            //    sb[index].Append(c);
            //    index += dir;// when going down  0,1,2,3,2,1,0
            //    if (index == 0 || index == numRows - 1) dir = -dir;
            //}
            for (int i = 0; i < s.Length; i++)
            {
                sb[index].Append(s[i]);
                index += dir;// when going down  0,1,2,3,2,1,0
                if (index == 0 || index == numRows - 1) dir = -dir;
            }
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < sb.Length; i++) res.Append(sb[i]);

            return res.ToString();
        }
    }
}
