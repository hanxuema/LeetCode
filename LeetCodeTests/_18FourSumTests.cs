using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class _18FourSumTests
    {
        [TestMethod()]
        public void FourSumTest()
        {
            var test = new int[] { 1, 0, -1, 0, -2, 2 };
            var fourSum = new _18FourSum();
            var result = fourSum.FourSum(test,0);

            var r = new List<List<int>>();

            r.Add(new List<int>() { -1, 0, 0, 1 });
            r.Add(new List<int>() { -2, -1, 1, 2 });
            r.Add(new List<int>() { -2, 0, 0, 2 });

            result.SequenceEqual(r);


        }
    }
}