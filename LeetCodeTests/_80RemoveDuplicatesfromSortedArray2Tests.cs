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
    public class _80RemoveDuplicatesfromSortedArray2Tests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            var rdfsa = new _80RemoveDuplicatesfromSortedArray2();
            var re = rdfsa.RemoveDuplicates(new int[] { 1, 1, 1, 2, 2, 3 });
            Assert.AreEqual(re, 5);                   //0, 1, 2, 3, 4, 2, 2, 3, 3, 4

            re = rdfsa.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 });
            Assert.AreEqual(re, 7);               //0, 1, 2, 3, 2, 3
        }
    }
}