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
    public class _9PalindromeNumberTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            var pn = new _9PalindromeNumber();
            Assert.IsTrue(pn.IsPalindrome(122221));

            Assert.IsTrue(pn.IsPalindrome(123454321));

            Assert.IsTrue(pn.IsPalindrome(121));

            Assert.IsFalse(pn.IsPalindrome(-121));

            Assert.IsFalse(pn.IsPalindrome(10));
        }
    }
}
