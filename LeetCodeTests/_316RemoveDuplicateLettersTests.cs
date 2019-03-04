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
    public class _316RemoveDuplicateLettersTests
    {
        [TestMethod()]
        public void RemoveDuplicateLettersTestShouldReturnABC()
        {
            var rdl = new _316RemoveDuplicateLetters();
            var result = rdl.RemoveDuplicateLetters("bcabc");
            Assert.AreEqual("abc", result);
        }
        [TestMethod()]
        public void RemoveDuplicateLettersTestShouldReturnACDB()
        {
            var rdl = new _316RemoveDuplicateLetters();
            var result = rdl.RemoveDuplicateLetters("cbacdcbc");
            Assert.AreEqual("acdb", result);
        }
    }
}