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
    public class _283MoveZeroesTests
    {
        [TestMethod()]
        public void MoveZeroesTest()
        {
            var mz = new _283MoveZeroes();

            var input = new int[] { 0,1 };
            mz.MoveZeroes(input);

            Assert.AreEqual(input.SequenceEqual(new int[] { 1,0 }), true);
        }
    }
}