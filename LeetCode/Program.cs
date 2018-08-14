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

            var i = 0;
            var d = 0.2;
            var s = "@#$";
            var newInt = Convert.ToInt32(Console.ReadLine());
            var newDouble = Convert.ToDouble(Console.ReadLine());
            var newStr = Console.ReadLine();

            // Read and save an integer, double, and String to your variables.

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + newInt);

            // Print the sum of the double variables on a new line.
            Console.WriteLine(d + newDouble);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + newStr);
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
