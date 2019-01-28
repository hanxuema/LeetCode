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
    public class _14LongestCommonPrefixTests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest()
        {
            var lcp = new _14LongestCommonPrefix();
            var result = lcp.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            Assert.AreEqual("fl", result);
        }

        [TestMethod()]
        public void LongestCommonPrefixShouldReturnEmptyString()
        {
            var lcp = new _14LongestCommonPrefix();
            var result = lcp.LongestCommonPrefix(new string[] { "b", "cb", "cab" });
            Assert.AreEqual("", result);
        }
    }
}