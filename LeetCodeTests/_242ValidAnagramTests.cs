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
    public class _242ValidAnagramTests
    {
        //Example 1:

        //Input: s = "anagram", t = "nagaram"
        //            nagaram
        //Output: true
        //Example 2:


        //Input: s = "rat", t = "car"
        //Output: false
        [TestMethod()]
        public void IsAnagramTest1()
        {
            var ia = new _242ValidAnagram();
            var s = "anagram";
            var t = "nagaram";
            var res = ia.IsAnagram(s,t);
            Assert.AreEqual(true, res);
        }

        [TestMethod()]
        public void IsAnagramTest2()
        {
            var ia = new _242ValidAnagram();
            var s = "rat";
            var t = "car";
            var res = ia.IsAnagram(s, t);
            Assert.AreEqual(false, res);
        }
    }
}