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
    public class GaltonGoogleTests
    {
        [TestMethod()]
        public void ReturnWordTest()
        {
            var rw = new GaltonGoogle();
            var result = rw.ReturnWord("this is good open nice office walala gate iii", "google");


        }
    }
}