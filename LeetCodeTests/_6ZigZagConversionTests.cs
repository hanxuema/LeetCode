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
    public class _6ZigZagConversionTests
    {
        [TestMethod()]
        public void ConvertTest1()
        {
            var zzc = new _6ZigZagConversion();
            var result = zzc.Convert("PAYPALISHIRING", 4);
            Assert.AreEqual("PINALSIGYAHRPI", result);
        }
        [TestMethod()]
        public void ConvertTest2()
        {
            var zzc = new _6ZigZagConversion();
            var result = zzc.Convert("PAYPALISHIRING", 3);
            Assert.AreEqual("PAHNAPLSIIGYIR", result);
        }
 
    }
}