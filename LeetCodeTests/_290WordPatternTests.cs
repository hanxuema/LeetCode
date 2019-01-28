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
    public class _290WordPatternTests
    {
        //Input: pattern = "abba", str = "dog cat cat dog"
        //Output: true
        //Example 2:

        //Input:pattern = "abba", str = "dog cat cat fish"
        //Output: false
        //Example 3:

        //Input: pattern = "aaaa", str = "dog cat cat dog"
        //Output: false
        //Example 4:

        //Input: pattern = "abba", str = "dog dog dog dog"
        //Output: false
        [TestMethod()]
        public void WordPatternTest1()
        {
            var wp = new _290WordPattern();
            var pattern = "abba"; var str = "dog cat cat dog";
            var result = wp.WordPattern(pattern, str);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void WordPatternTest2()
        {
            var wp = new _290WordPattern();
            var pattern = "abba"; var str = "dog cat cat fish";
            var result = wp.WordPattern(pattern, str);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void WordPatternTest3()
        {
            var wp = new _290WordPattern();
            var pattern = "aaaa"; var str = "dog cat cat dog";
            var result = wp.WordPattern(pattern, str);
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void WordPatternTest4()
        {
            var wp = new _290WordPattern();
            var pattern = "abba"; var str = "dog dog dog dog";
            var result = wp.WordPattern(pattern, str);
            Assert.AreEqual(false, result);
        }
    }
}