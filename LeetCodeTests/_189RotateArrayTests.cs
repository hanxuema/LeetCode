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
    public class _189RotateArrayTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            var aa = new _189RotateArray();
            var testArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            aa.Rotate(testArray, 3);
            Assert.IsTrue(testArray.SequenceEqual(new int[] { 5, 6, 7, 1, 2, 3, 4 }));

            aa.Rotate(testArray, 3);
            Assert.IsTrue(testArray.SequenceEqual(new int[] { 2, 3, 4, 5, 6, 7, 1 }));

            aa.Rotate(testArray, 30);
            Assert.IsTrue(testArray.SequenceEqual(new int[] { 7, 1, 2, 3, 4, 5, 6  }));
        }
    }
}