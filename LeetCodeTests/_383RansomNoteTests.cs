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
    public class _383RansomNoteTests
    { 
        //canConstruct("a", "b") -> false
        //canConstruct("aa", "ab") -> false
        //canConstruct("aa", "aab") -> true

        [TestMethod()]
        public void CanConstructTest()
        {
            var cc = new _383RansomNote();
            var result = cc.CanConstruct("a", "b");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void CanConstructShouldReturnFalse()
        {
            var cc = new _383RansomNote();
            var result = cc.CanConstruct("aa", "ab");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void CanConstructShouldReturnTrue()
        {
            var cc = new _383RansomNote();
            var result = cc.CanConstruct("aa", "aab");
            Assert.AreEqual(true, result);
        }
    }
}