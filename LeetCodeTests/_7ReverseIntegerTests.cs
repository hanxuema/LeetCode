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
    public class _7ReverseIntegerTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            var c = new _7ReverseInteger();
            var result = c.Reverse(123);
            Assert.AreEqual(result, 321);

            result = c.Reverse(-123);
            Assert.AreEqual(result, -321);

            result = c.Reverse(120);
            Assert.AreEqual(result, 21);

            result = c.Reverse(-2147483648);
            Assert.AreEqual(result, 0);
         
        }
    }
}