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
    public class _832FlippinganImageTests
    {
        [TestMethod()]
        public void FlipAndInvertImageTest()
        {
            var flip = new _832FlippinganImage();

            var input = new int[][] { new int[] { 1, 1, 0, 0 }, new int[] { 1, 0, 0, 1 }, new int[] { 0, 1, 1, 1 }, new int[] { 1, 0, 1, 0 } };

            var r = new int[][] { new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 1, 0 }, new int[] { 0, 0, 0, 1 }, new int[] { 1, 0, 1, 0 } };
            var result = flip.FlipAndInvertImage(input);

            Assert.IsTrue(r.SequenceEqual(result));
        }
    }
}