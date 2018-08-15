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
    public class _657JudgeRouteCircleTests
    {
        [TestMethod()]
        public void JudgeCircleTest()
        {
            var j = new _657JudgeRouteCircle();

            var result = j.JudgeCircle("UD");

            Assert.IsTrue(result);
        }
    }
}