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
    public class _461HammingDistanceTests
    {
        [TestMethod()]
        public void HammingDistanceTest()
        {
            var ham = new _461HammingDistance();

            var result = ham.HammingDistance(1, 4);
            Assert.AreEqual(result, 2);
        }
    }
}