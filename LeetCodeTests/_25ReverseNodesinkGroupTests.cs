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
            var ar = new int[] { 1, 2, 3, 4, 5 };
            ListNode node = null;
            ListNode currentNode = null;
            for (int i = 0; i < ar.Length; i++)
            {
                var newNode = new ListNode(ar[i]);
                if (node == null)
                {
                    node = newNode;
                }
                currentNode.next = newNode;
            }


            Assert.Fail();
        }
    }
}