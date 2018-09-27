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
    public class _26RemoveDuplicatesfromSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            var rdfsa = new _26RemoveDuplicatesfromSortedArray();
            var re = rdfsa.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Assert.AreEqual(re, 5);

        }
    }
}