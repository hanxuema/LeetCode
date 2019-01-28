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
    public class _58LengthofLastWordTests
    {
        [TestMethod()]
        public void LengthOfLastWordTest()
        {
            var lolw = new _58LengthofLastWord();
            var result = lolw.LengthOfLastWord("Hello world");
            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void LengthOfLastWordShouldReturn5()
        {
            var lolw = new _58LengthofLastWord();
            var result = lolw.LengthOfLastWord("world");
            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void LengthOfLastWordShouldReturn0()
        {
            var lolw = new _58LengthofLastWord();
            var result = lolw.LengthOfLastWord("");
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void LengthOfLastWordShouldReturn1()
        {
            var lolw = new _58LengthofLastWord();
            var result = lolw.LengthOfLastWord(" a ");
            Assert.AreEqual(1, result);
        }
    }
}