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
    public class _20ValidParenthesesTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            var vp= new _20ValidParentheses();
            var result = vp.IsValid("(]");

            Assert.IsFalse(result);
        }
    }
}