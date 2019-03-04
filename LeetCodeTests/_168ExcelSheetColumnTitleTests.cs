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
    public class _168ExcelSheetColumnTitleTests
    {
        [TestMethod()]
        public void ConvertToTitleTest1()
        {
            var esct = new _168ExcelSheetColumnTitle();
            var result = esct.ConvertToTitle(1);
            Assert.AreEqual("A", result);
        }

        [TestMethod()]
        public void ConvertToTitleTest2()
        {
            var esct = new _168ExcelSheetColumnTitle();
            var result = esct.ConvertToTitle(28);
            Assert.AreEqual("AB", result);
        }

        [TestMethod()]
        public void ConvertToTitleTest3()
        {
            var esct = new _168ExcelSheetColumnTitle();
            var result = esct.ConvertToTitle(701);
            Assert.AreEqual("ZY", result);
        }
    }
}