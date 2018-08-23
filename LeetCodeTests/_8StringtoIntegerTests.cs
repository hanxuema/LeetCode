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
    public class _8StringtoIntegerTests
    {
        [TestMethod()]
        public void MyAtoiTest()
        {
            var st = new _8StringtoInteger();
            var result = st.MyAtoi("  -0012a42");
            Assert.AreEqual(result,-12);


        }
    }
}