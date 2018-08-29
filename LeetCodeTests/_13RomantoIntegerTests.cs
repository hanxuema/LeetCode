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
    public class _13RomantoIntegerTests
    {
        [TestMethod()]
        public void RomanToIntTest()
        {
            //Example 1:

            //Input: "III"
            //Output: 3
            //Example 2:

            //Input: "IV"
            //Output: 4
            //Example 3:

            //Input: "IX"
            //Output: 9
            //Example 4:

            //Input: "LVIII"
            //Output: 58
            //Explanation: C = 100, L = 50, XXX = 30 and III = 3.
            //Example 5:

            //Input: "MCMXCIV"
            //Output: 1994
            var ri = new _13RomantoInteger();
            Assert.AreEqual(ri.RomanToInt("III"), 3);
            Assert.AreEqual(ri.RomanToInt("IV"), 4);
            Assert.AreEqual(ri.RomanToInt("IX"), 9);
            Assert.AreEqual(ri.RomanToInt("LVIII"), 58);
            Assert.AreEqual(ri.RomanToInt("MCMXCIV"), 1994);
        }
    }
}