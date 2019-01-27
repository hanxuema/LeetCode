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
    public class _42TrappingRainWaterTests
    {
        [TestMethod()]
        public void TrapTest()
        {
            var trap = new _42TrappingRainWater();
            var result = trap.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            Assert.AreEqual(6, result);
        }
    }
}