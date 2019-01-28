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
    public class _151ReverseWordsinaStringTests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            //Input: "the sky is blue",
            //Output: "blue is sky the".
            var rw = new _151ReverseWordsinaString();
            var result = rw.ReverseWords(" the    sky ");
            Assert.AreEqual("sky the", result);
        }
    }
}