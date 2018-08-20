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
    public class _2AddTwoNumbersTests
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {
            var cl = new _25ReverseNodesinkGroup();

            var ar = new int[] { 2, 4, 3 };
            var head = cl.convertArrayToListNode(ar);

            var ar2 = new int[] { 5, 6, 4 };
            var head2 = cl.convertArrayToListNode(ar2); 

            var atn = new _2AddTwoNumbers();
            var result = atn.AddTwoNumbers(head, head2);

            
        }
    }
}