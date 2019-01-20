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
    public class _41FirstMissingPositiveTests
    {
        [TestMethod()]
        public void FirstMissingPositiveTest()
        {
            var fmp = new _41FirstMissingPositive();

            var result = fmp.FirstMissingPositive(new int[] { 1, 2, 0 });
            Assert.AreEqual(result, 3);

            result = fmp.FirstMissingPositive(new int[] { 2 });
            Assert.AreEqual(result, 1);


            result = fmp.FirstMissingPositive(new int[] { 3, 4, -1, 1 });
            Assert.AreEqual(result, 2);

            result = fmp.FirstMissingPositive(new int[] { 7, 8, 9, 11, 12 });
            Assert.AreEqual(result, 1);


        }
    }
}