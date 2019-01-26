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
    public class _11ContainerWithMostWaterTests
    {
        [TestMethod()]
        public void MaxAreaTest()
        {
            var mr = new _11ContainerWithMostWater();
            var result = mr.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            Assert.AreEqual(49, result);
        }
    }
}