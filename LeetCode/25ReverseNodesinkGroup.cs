using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class _25ReverseNodesinkGroup
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        { 
            ListNode next = null;
            var currentIndex = 1;
            while (head != null)
            {
                next = head.next;
                next.next = head;
                head = next;
                currentIndex++;
                if (currentIndex == k)
                {
                    head.next = null;
                    break;
                }
            }
            return head;
        }
    }
}
