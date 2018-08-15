using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _832FlippinganImage
    {
        //Given a binary matrix A, we want to flip the image horizontally, then invert it, and return the resulting image.

        //To flip an image horizontally means that each row of the image is reversed.For example, flipping[1, 1, 0] horizontally results in [0, 1, 1].

        //To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0. For example, inverting[0, 1, 1] results in [1, 0, 0].

        //Example 1:
        //Input: [[1,1,0],[1,0,1],[0,0,0]]
        //Output: [[1,0,0],[0,1,0],[1,1,1]]
        //Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
        //Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]

        //Example 2:
        //Input: [[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
        //Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
        //Explanation: First reverse each row: [[0,0,1,1],[1,0,0,1],[1,1,1,0],[0,1,0,1]].
        //Then invert the image: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]

        public int[][] FlipAndInvertImage(int[][] A)
        {
            var result = new int[A.Length][];
            for (int i = 0; i < A.Length; i++)
            {
                var ar = A[i];
                var newar = new int[ar.Length];
                for (int k = 0; k < ar.Length; k++)
                {
                    newar[ar.Length - k - 1] = Math.Abs(1 - ar[k]);
                }
                result[i] = newar;
            }

            return result;
        }
    }
}
