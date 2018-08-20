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
            ListNode first = null;
            var index = 0;
            var nextValue = 0;

            while (l1 != null && l2 != null)
            {
                //for loop each node
                next1 = l1.next;
                next2 = l2.next;

                var value = l1.val + l2.val;
                value = value + nextValue;
                if (value > 9)
                {
                    l1.val = value % 10;
                    nextValue = (value - l1.val) / 10;
                }
                else
                {
                    l1.val = value;
                    nextValue = 0;
                }
                pre = l1;

                if (nextValue > 0 && next1 == null)
                {
                    var newNode = new ListNode(nextValue);
                    l1.next = newNode;
                }

                l1 = next1;
                l2 = next2;

              
                if (index == 0)
                {
                    first = pre;
                }
                index++;
            }


            return first;
        }
    }
}
