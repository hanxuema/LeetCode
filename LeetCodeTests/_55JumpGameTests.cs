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
    public class _55JumpGameTests
    {
        [TestMethod()]
        public void CanJumpTestShouldReturnTrue()
        {
            var cj = new _55JumpGame();
            var result = cj.CanJump(new int[] { 2, 3, 1, 1, 4 });

            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void CanJumpTestShouldReturnFalse()
        {
            var cj = new _55JumpGame();
            var result = cj.CanJump(new int[] { 3, 2, 1, 0, 4 });

            Assert.AreEqual(false, result);
        }
    }
}