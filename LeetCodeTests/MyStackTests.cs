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
    public class MyStackTests
    {
        [TestMethod()]
        public void MyStackTest()
        {
            MyStack stack = new MyStack();

            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(stack.Top(), 2);   // returns 2
            Assert.AreEqual(stack.Pop(), 2);   // returns 2
            Assert.AreEqual(stack.Empty(), false); // returns false
        }

        [TestMethod()]
        public void PushTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PopTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TopTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EmptyTest()
        {
            Assert.Fail();
        }
    }
}