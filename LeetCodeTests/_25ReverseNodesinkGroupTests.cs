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
    public class _25ReverseNodesinkGroupTests
    {
        [TestMethod()]
        public void ReverseKGroupTest()
        {
            //1->2->3->4->5
            var cl = new _25ReverseNodesinkGroup();

            var ar = new int[] { 1, 2, 3, 4, 5 };
            var head = cl.convertArrayToListNode(ar);
        
            var ar2 = new int[] { 3, 2, 1, 4, 5 };
            var head2 = cl.convertArrayToListNode(ar2);

            var result = new _25ReverseNodesinkGroup().ReverseKGroup(head, 3);

            Assert.IsTrue(cl.convertListNodeToArray(head2).SequenceEqual(new int[] { 3, 2, 1, 4, 5 }));

        }

        [TestMethod()]
        public void convertArrayToListNodeTest()
        {
            var ar = new int[] { 1, 2, 3, 4, 5 };
            var cl = new _25ReverseNodesinkGroup();
            var head = cl.convertArrayToListNode(ar);

        }

        [TestMethod()]
        public void convertListNodeToArrayTest()
        {
            var ar = new int[] { 1, 2, 3, 4, 5 };
            var cl = new _25ReverseNodesinkGroup();
            var head = cl.convertArrayToListNode(ar);

            var re = cl.convertListNodeToArray(head);
            Assert.IsTrue(ar.SequenceEqual(re));
        }

        [TestMethod()]
        public void ReverseKGroup2Test()
        { //1->2->3->4->5
            var cl = new _25ReverseNodesinkGroup();

            var ar = new int[] { 1, 2, 3, 4, 5 };
            var head = cl.convertArrayToListNode(ar);

            var ar2 = new int[] { 3, 2, 1, 4, 5 };
            var head2 = cl.convertArrayToListNode(ar2);

            var result = new _25ReverseNodesinkGroup().ReverseKGroup2(head, 3);

            Assert.IsTrue(cl.convertListNodeToArray(head2).SequenceEqual(new int[] { 3, 2, 1, 4, 5 }));
        }
    }
}