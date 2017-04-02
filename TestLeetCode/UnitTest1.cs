using System;
using NUnit.Framework;
using static LeetCode.Program;

namespace TestLeetCode
{
    [TestFixture]
    public class TestReverse
    {
        Solution sol;
        [SetUp]
        public void Init()
        {
            sol = new Solution();
        }

        [Test]
        public void ReverseShowReturnReverseNumber()
        {
            var result = sol.Reverse(123);

            Assert.AreEqual(result, 321);
        }

        [Test]
        public void ReverseShowReturnZeroIfInputIsZero()
        {
            var result = sol.Reverse(0);

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void ReverseShowReturnZeroIfResultIsOverflow()
        {
            var result = sol.Reverse(2147483647);

            Assert.AreEqual(result, 0);
        }
    }
}
