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
    public class _350IntersectionofTwoArraysIITests
    {
        [TestMethod()]
        public void IntersectTest()
        {
            //[1,2,2,1]
            //[2,2]
            var nums1 = new int[] { 1, 2, 2, 1 };
            var nums2 = new int[] { 2, 2 };
            var iota = new _350IntersectionofTwoArraysII();
            var result = iota.Intersect(nums1, nums2);

            Assert.IsTrue(result.SequenceEqual(new int[] { 2, 2 }));
    
        }
    }
}