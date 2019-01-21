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
    public class _217ContainsDuplicateTests
    {
        [TestMethod()]
        public void ContainsDuplicateTest()
        {
            var cd = new _217ContainsDuplicate();
            var result = cd.ContainsDuplicate(new int[] {3,3});

            Assert.AreEqual(true, result);
        }
    }
}