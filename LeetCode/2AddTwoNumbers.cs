using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _2AddTwoNumbers
    {
        //You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.

        //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        //Example:

        //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 0 -> 8
        //Explanation: 342 + 465 = 807.

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode next1 = null;
            ListNode next2 = null;

            ListNode pre = null;
            ListNode cur = null;
            var valueToAdd = 0;
            while (l1 != null && l2 != null)
            {
                var curValue = l1.val + l2.val;
                cur = l1;
                next1 = l1.next;
                next2 = l2.next;

                if (curValue > 9)
                {
                    cur.val = curValue % 10;
                    valueToAdd = pre.val + (curValue - cur.val) / 10;
                }
                else
                {
                    cur.val = curValue;
                    valueToAdd = 0;
                }

                if (pre != null)
                {
                    pre.next = cur;
                }
                pre = cur;

                l1 = next1;
                l2 = next2;
            }

            return l1;
        }
    }
}
