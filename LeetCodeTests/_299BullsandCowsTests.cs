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
    public class _299BullsandCowsTests
    {
        [TestMethod()]
        public void GetHintShouldReturn1A3BIfSecretIs1807AndGuessIs7810()
        {
            var gh = new _299BullsandCows();
            var value = gh.GetHint("1807", "7810");

            Assert.AreEqual("1A3B", value);
        }

        [TestMethod()]
        public void GetHintShouldReturn1A3BIfSecretIs1123AndGuessIs0111()
        {
            var gh = new _299BullsandCows();
            var value = gh.GetHint("1123", "0111");

            Assert.AreEqual("1A1B", value);
        }

        [TestMethod()]
        public void GetHintShouldReturn0A4BIfSecretIs1122AndGuessIs2211()
        {
            var gh = new _299BullsandCows();
            var value = gh.GetHint("1122", "2211");

            Assert.AreEqual("0A4B", value);
        }

        [TestMethod()]
        public void GetHintShouldReturn0A4BIfSecretIs1122AndGuessIs1222()
        {
            var gh = new _299BullsandCows();
            var value = gh.GetHint("1122", "1222");

            Assert.AreEqual("3A0B", value);
        }
    }
}
