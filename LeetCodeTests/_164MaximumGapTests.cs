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
    public class _164MaximumGapTests
    {
        [TestMethod()]
        public void MaximumGapTest()
        {
            var mg = new _164MaximumGap();
            var result = mg.MaximumGap(new int[] { 3, 6, 9, 1 });
            Assert.AreEqual(3,result);
        }

        [TestMethod()]
        public void MaximumGapShouldReturn0()
        {
            var mg = new _164MaximumGap();
            var result = mg.MaximumGap(new int[] { 10 });
            Assert.AreEqual(0, result);
        }
    }
}