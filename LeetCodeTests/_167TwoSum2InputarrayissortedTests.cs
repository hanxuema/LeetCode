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
    public class _167TwoSum2InputarrayissortedTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            var nums1 = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var nums2 = new int[] { 2, 2 };
            var ts = new _167TwoSum2Inputarrayissorted();
            var result = ts.TwoSum(nums1, target);

            Assert.IsTrue(result.SequenceEqual(new int[] { 1, 2 }));
        }
    }
}