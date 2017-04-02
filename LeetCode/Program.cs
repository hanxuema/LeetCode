using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

        }

        public class Solution
        {
            /// <summary>
            /// Reverse integer
            /// </summary>
            /// <param name="x"></param>
            /// <returns>Return reverse of an integer, if overflow, return 0</returns>
            public int Reverse(int x)
            {
                //biggest int is 2147483647
                if (x == 0)
                {
                    return 0;
                }
                if (x < 0)
                {

                }
                return 0;
               // var result = x.ToString().Reverse().Select(xx => (int)xx);
                
            }
        }
    }
}
