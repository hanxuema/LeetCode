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
    public class _344ReverseStringTests
    {
        [TestMethod()]
        public void ReverseStringTest()
        {
            var re = new _344ReverseString();
            var result = re.ReverseString("ABC ADD : uisd");
            Assert.AreEqual(result, "dsiu : DDA CBA");
        }
    }
}