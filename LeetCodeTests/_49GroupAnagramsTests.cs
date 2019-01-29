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
    public class _49GroupAnagramsTests
    {
        //Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
        //Output:
        //[
        //  ["ate","eat","tea"],
        //  ["nat","tan"],
        //  ["bat"]
        //]
        [TestMethod()]
        public void GroupAnagramsTest()
        {
            var ga = new _49GroupAnagrams();
            var result = ga.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

            var test = result[0].OrderBy(r=>r).SequenceEqual(new string[] { "ate", "eat", "tea" }) ||
                   result[0].OrderBy(r => r).SequenceEqual(new string[] { "nat", "tan" }) ||
                   result[0].OrderBy(r => r).SequenceEqual(new string[] { "bat" });

            Assert.AreEqual(test, true);
        }
    }
}