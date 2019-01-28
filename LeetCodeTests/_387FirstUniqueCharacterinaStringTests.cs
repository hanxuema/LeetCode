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
    public class _387FirstUniqueCharacterinaStringTests
    {
        [TestMethod()]
        public void FirstUniqCharShouldReturn2()
        {
            var fuc = new _387FirstUniqueCharacterinaString();
            var reulst = fuc.FirstUniqChar("loveleetcode");
            Assert.AreEqual(2, reulst);
        }

        [TestMethod()]
        public void FirstUniqCharShouldReturn0()
        {
            var fuc = new _387FirstUniqueCharacterinaString();
            var reulst = fuc.FirstUniqChar("leetcode");
            Assert.AreEqual(0, reulst);
        }
    }
}