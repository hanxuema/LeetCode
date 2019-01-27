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
    public class _128LongestConsecutiveSequenceTests
    {
        [TestMethod()]
        public void LongestConsecutiveTest()
        {
            var lc = new _128LongestConsecutiveSequence();
            var result = lc.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void LongestConsecutiveShouldReturn5()
        {
            var lc = new _128LongestConsecutiveSequence();
            var result = lc.LongestConsecutive(new int[] {5, 100, 4, 200, 1, 3, 2 });
            Assert.AreEqual(5, result);
        }
    }
}