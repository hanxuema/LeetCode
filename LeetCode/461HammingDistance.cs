using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _461HammingDistance
    {
        //The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

        //Given two integers x and y, calculate the Hamming distance.

        //Note:
        //0 ≤ x, y< 231.

        //Example:

        //Input: x = 1, y = 4

        //Output: 2

        //Explanation:
        //1   (0 0 0 1)
        //4   (0 1 0 0)
        //       ↑   ↑

        //The above arrows point to positions where the corresponding bits are different.

        public int HammingDistance(int x, int y)
        {
            var result = 0;
            //first let's XOR x and y
            var t = x ^ y;
            //and find how many 1 left
            while (t > 0)
            {
                result = result + t % 2;
                t >>=1;
            }
            return result;
        }
    }
}
