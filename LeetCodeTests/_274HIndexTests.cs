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
    public class _274HIndexTests
    {
        [TestMethod()]
        public void HIndexShouldReturn3()
        {
            var hi = new _274HIndex();
            var result = hi.HIndex(new int[] { 3, 0, 6, 1, 5 });
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void HIndexShouldReturn4()
        {
            var hi = new _274HIndex();
            var result = hi.HIndex(new int[] { 7,4,6,2,4 });
            Assert.AreEqual(4, result);
        }
    }
}