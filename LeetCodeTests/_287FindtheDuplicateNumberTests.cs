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
    public class _287FindtheDuplicateNumberTests
    {
        [TestMethod()]
        public void FindDuplicateTest()
        {
            var fd = new _287FindtheDuplicateNumber();
            var result = fd.FindDuplicate(new int[] { 1, 3, 4, 2, 2 });
            Assert.AreEqual(2,result);
        }

        [TestMethod()]
        public void FindDuplicateShouldReturn3()
        {
            var fd = new _287FindtheDuplicateNumber();
            var result = fd.FindDuplicate(new int[] { 3, 1, 3, 4, 2 });
            Assert.AreEqual(3, result);
        }


 
    }
}