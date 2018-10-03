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
    public class _349IntersectionofTwoArraysTests
    {
        [TestMethod()]
        public void IntersectionTest()
        {
            var nums1 = new int[] { 1, 2, 2, 1 };
            var nums2 = new int[] { 2, 2 };
            var iota = new _349IntersectionofTwoArrays();
            var result = iota.Intersection(nums1, nums2);

            Assert.IsTrue(result.SequenceEqual(new int[] { 2 }));
            
        }
    }
}