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
    public class _179LargestNumberTests
    {
        [TestMethod()]
        public void LargestNumberTest()
        {
            var ln = new _179LargestNumber();
            var result = ln.LargestNumber(new int[] { 3, 30, 34, 5, 9 });
            Assert.AreEqual("9534330", result);
        }

        [TestMethod()]
        public void LargestNumberTest2()
        {
            var ln = new _179LargestNumber();
            var result = ln.LargestNumber(new int[] { 10, 2 });
            Assert.AreEqual("210", result);
        }
    }
}