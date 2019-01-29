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
    public class _28ImplementstrStrTests
    {
        [TestMethod()]
        public void StrStrTest()
        {
            var ss = new _28ImplementstrStr();
            var reulst = ss.StrStr("hello", "ll");
            Assert.AreEqual(2, reulst);
        }

        [TestMethod()]
        public void StrStrShouldReturn0()
        {
            var ss = new _28ImplementstrStr();
            var reulst = ss.StrStr("a", "a");
            Assert.AreEqual(0, reulst);
        }

        [TestMethod()]
        public void StrStrShouldReturnMinus1()
        {
            var ss = new _28ImplementstrStr();
            var reulst = ss.StrStr("aaaaa", "bba");
            Assert.AreEqual(-1, reulst);
        }

        [TestMethod()]
        public void StrStrShouldReturnMinus1Again()
        {
            var ss = new _28ImplementstrStr();
            var reulst = ss.StrStr("hello", "llu");
            Assert.AreEqual(-1, reulst);
        }
    }
}