﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _728SelfDividingNumbers
    {
        //A self-dividing number is a number that is divisible by every digit it contains.

        //For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.

        //Also, a self-dividing number is not allowed to contain the digit zero.

        //Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.

        //Example 1:
        //Input: 
        //left = 1, right = 22
        //Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
        //Note:

        //The boundaries of each input argument are 1 <= left <= right <= 10000.
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                var currentValue = i;
                var isSelfDividingNumber = true;
                do
                {
                    var temp = currentValue % 10;
                    if (temp == 0 || (i % temp) != 0)
                    {
                        isSelfDividingNumber = false;
                    }
                    currentValue = currentValue / 10;//for each digit
                }
                while (currentValue > 1);

                if (isSelfDividingNumber)
                {
                    result.Add(i);
                }

            }

            return result;
        }
    }
}