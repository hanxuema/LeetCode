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
    public class _345ReverseVowelsofaStringTests
    {
        [TestMethod()]
        public void ReverseVowelsTest()
        {
            //Input: "leetcode"
            //Output: "leotcede"
            var rv = new _345ReverseVowelsofaString();
            var result = rv.ReverseVowels("leetcode");
            Assert.AreEqual("leotcede", result);
        }

        [TestMethod()]
        public void ReverseVowelsTest2()
        {
            //Input: "leetcode"
            //Output: "leotcede"
            var rv = new _345ReverseVowelsofaString();
            var result = rv.ReverseVowels("hello");
            Assert.AreEqual("holle", result);
        }

        [TestMethod()]
        public void ReverseVowelsTest3()
        {
            //Input: "leetcode"
            //Output: "leotcede"
            var rv = new _345ReverseVowelsofaString();
            var result = rv.ReverseVowels("jkl");
            Assert.AreEqual("jkl", result);
        }

        [TestMethod()]
        public void ReverseVowelsTest4()
        {
            //Input: "leetcode"
            //Output: "leotcede"
            var rv = new _345ReverseVowelsofaString();
            var result = rv.ReverseVowels(" a");
            Assert.AreEqual(" a", result);
        }

        [TestMethod()]
        public void ReverseVowelsTest5()
        {
            //Input: "leetcode"
            //Output: "leotcede"
            var rv = new _345ReverseVowelsofaString();
            var result = rv.ReverseVowels("Aa");
            Assert.AreEqual("aA", result);
        }
    }
}