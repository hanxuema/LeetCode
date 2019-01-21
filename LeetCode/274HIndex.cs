using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an array of citations(each citation is a non-negative integer) of a researcher, write a function to compute the researcher's h-index.

    //According to the definition of h-index on Wikipedia: "A scientist has index h if h of his/her N papers have at least h citations each, and the other N − h papers have no more than h citations each."

    //Example:

    //Input: citations = [3,0,6,1,5]
    //    Output: 3 
    //Explanation: [3,0,6,1,5] means the researcher has 5 papers in total and each of them had
    //             received 3, 0, 6, 1, 5 citations respectively.
    //             Since the researcher has 3 papers with at least 3 citations each and the remaining
    //             two with no more than 3 citations each, her h-index is 3.
    //Note: If there are several possible values for h, the maximum one is taken as the h-index.
    public class _274HIndex
    {
        public int HIndex(int[] citations)
        {
            //check corner case
            if (citations == null || citations.Length == 0) return 0;
            var result = 0;
            //sort the citations
            Array.Sort(citations);
            //for loop and check the "distance" to the end of the array 
            for (int i = citations.Length - 1; i >= 0; i--)
            {
                int h = citations.Length - i;
                if (citations[i] < h)
                {
                    return h - 1;
                }
            }
            return citations.Length;
        }
    }
}
