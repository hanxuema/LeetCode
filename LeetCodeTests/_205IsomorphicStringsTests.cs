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
    public class _205IsomorphicStringsTests
    {
        //Input: s = "egg", t = "add"
        //Output: true
        //Example 2:


        //Input: s = "foo", t = "bar"
        //Output: false
        //Example 3:


        //Input: s = "paper", t = "title"
        //Output: true

        [TestMethod()]
        public void IsIsomorphicTest1()
        {
            var ii = new _205IsomorphicStrings();
            var result = ii.IsIsomorphic("egg", "add");
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void IsIsomorphicTest2()
        {
            var ii = new _205IsomorphicStrings();
            var result = ii.IsIsomorphic("foo", "bar");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void IsIsomorphicTest3()
        {
            var ii = new _205IsomorphicStrings();
            var result = ii.IsIsomorphic("paper", "title");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsIsomorphicTest4()
        {
            var ii = new _205IsomorphicStrings();
            var result = ii.IsIsomorphic(" ", " ");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsIsomorphicTest5()
        {
            var ii = new _205IsomorphicStrings();
            var result = ii.IsIsomorphic("a a", "b b");
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void IsIsomorphicTest6()
        {
            var ii = new _205IsomorphicStrings();
            var result = ii.IsIsomorphic("ab", "aa");
            Assert.AreEqual(false, result);
        }
    }
}