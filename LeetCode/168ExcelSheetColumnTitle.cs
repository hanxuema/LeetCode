using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _168ExcelSheetColumnTitle
    {
        //Given a positive integer, return its corresponding column title as appear in an Excel sheet.

        //For example:

        //    1 -> A
        //    2 -> B
        //    3 -> C
        //    ...
        //    26 -> Z
        //    27 -> AA
        //    28 -> AB
        //    ...
        //Example 1:

        //Input: 1
        //Output: "A"
        //Example 2:

        //Input: 28
        //Output: "AB"
        //Example 3:

        //Input: 701
        //Output: "ZY"

        public string ConvertToTitle(int n)
        {
            if (n <= 0) return "";
            //A 65  Z 90
            StringBuilder sb = new StringBuilder();

            while (n > 0)
            {
                n--;
                sb.Append((char)('A' + n % 26));
                n = n / 26;
            }

            var ab = sb.ToString().Reverse();
            return new string(ab.ToArray());
        }
    }
}
