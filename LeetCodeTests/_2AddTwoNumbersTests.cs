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

            var r = new int[] { 7, 0, 8 };

            Assert.IsTrue(cl.convertListNodeToArray(result).SequenceEqual(r));

            var ar3 = new int[] { 5 };
            var head3 = cl.convertArrayToListNode(ar3);

            var result3 = atn.AddTwoNumbers(head3, head3);

            Assert.IsTrue(cl.convertListNodeToArray(result3).SequenceEqual(new int[] { 0, 1 }));

            var ar5 = new int[] { 0 };
            var ar6 = new int[] { 7, 3 };
            var head5 = cl.convertArrayToListNode(ar5);
            var head6 = cl.convertArrayToListNode(ar6);

            var result6 = atn.AddTwoNumbers(head5, head6);

            Assert.IsTrue(cl.convertListNodeToArray(result6).SequenceEqual(new int[] { 7, 3 }));
        }
    }

}