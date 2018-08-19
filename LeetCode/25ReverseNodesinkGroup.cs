using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public ListNode ReverseKGroup2(ListNode head, int k)
        {
            ListNode current = head;
            ListNode next = null;
            ListNode prev = null;

            int count = 0;

            while (count < k && current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;//to assign prev to current
                current = next;//to move to the next node
                count++;
            }
            if (next != null)
                head.next = ReverseKGroup2(next, k);

            // prev is now head of input list
            return prev;
        }

        public ListNode convertArrayToListNode(int[] ar)
        {
            ListNode head = null;
            ListNode prevNode = null;
            ListNode currentNode = null;
            for (int i = 0; i < ar.Length; i++)
            {
                currentNode = new ListNode(ar[i]);
                if (head == null)
                {
                    head = currentNode;
                }
                if (prevNode != null)
                {
                    prevNode.next = currentNode;
                }
                prevNode = currentNode;
            }

            return head;
        }

        public int[] convertListNodeToArray(ListNode head)
        {
            var list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            return list.ToArray();
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode cur = head;
            var cidx = 0;
            while (cur != null && cidx != k)
            {
                cur = cur.next;
                cidx++;
            }
            if (cidx == k)
            {
                cur = ReverseKGroup(cur, k);
                while (cidx-- > 0)
                {
                    ListNode temp = head.next;
                    head.next = cur;
                    cur = head;
                    head = temp;
                }
                head = cur;
            }
            return head;
        }

        public void print(ListNode node, string pl)
        {
            if (node == null)
            {
                Debug.WriteLine(string.Format("{0} node value is null, next value is null", pl));
                return;
            }
            Debug.WriteLine(string.Format("{2} node value is {0}, next value is {1}", node.val, node.next.val, pl));
        }
    }
}
