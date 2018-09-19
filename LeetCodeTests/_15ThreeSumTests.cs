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
    public class _15ThreeSumTests
    {
        [TestMethod()]
        public void ThreeSumTest()
        {
            var threesum = new _15ThreeSum();
            var result = threesum.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

            var exp = new List<List<int>>();
            exp.Add(new List<int> { -1, 0, 1 });
            exp.Add(new List<int> { -1, -1,2 });
            
            Assert.IsTrue(result.SequenceEqual(exp));
        }
    }
}