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
    public class _334IncreasingTripletSubsequenceTests
    {
        [TestMethod()]
        public void IncreasingTripletTest()
        {
            var it = new _334IncreasingTripletSubsequence();
            var result = it.IncreasingTriplet(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IncreasingTripletShouldReturnFalse()
        {
            var it = new _334IncreasingTripletSubsequence();
            var result = it.IncreasingTriplet(new int[] { 5, 4, 3, 2, 1 });
            Assert.AreEqual(false, result);
        }


        [TestMethod()]
        public void IncreasingTripletShouldReturnTrue()
        {
            var it = new _334IncreasingTripletSubsequence();
            var result = it.IncreasingTriplet(new int[] { 5, 1, 5, 5, 2, 5, 4 });
            Assert.AreEqual(true, result);
        }
    }
}