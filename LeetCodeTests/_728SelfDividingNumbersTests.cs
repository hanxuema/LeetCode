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
    public class _728SelfDividingNumbersTests
    {
        [TestMethod()]
        public void SelfDividingNumbersTest()
        {
            var sdn = new _728SelfDividingNumbers();
            var rst = sdn.SelfDividingNumbers(1, 22);

            Assert.IsTrue(rst.ToArray().SequenceEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 }));
        }
    }
}