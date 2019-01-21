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
    public class _243ShortestWordDistanceTests
    {
        [TestMethod()]
        public void shortestDistanceShouldReturn3()
        {
            var std = new _243ShortestWordDistance();
            var result = std.shortestDistance(new string[] { "practice", "makes", "perfect", "coding", "makes" }, "coding", "practice");
            Assert.AreEqual(3,result);
        }

        [TestMethod()]
        public void shortestDistanceShouldReturn1()
        {
            var std = new _243ShortestWordDistance();
            var result = std.shortestDistance(new string[] { "practice", "makes", "perfect", "coding", "makes" }, "coding", "makes");
            Assert.AreEqual(1, result);
        }
    }
}