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
    public class _125ValidPalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            var input = "A man, a plan, a canal: Panama";
            var vp = new _125ValidPalindrome();

            var reu = vp.IsPalindrome(".,");
            Assert.IsTrue(reu);
        }
    }
}