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

        //Input:
        //[0]
        //[7,3]
        //Output:
        //[7]
        //Expected:
        //[7,3]

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        { 
            ListNode first = new ListNode(0);
            ListNode result = first;
            var index = 0;

            var carry = 0;

            while (l1 != null || l2 != null || carry ==1 )
            {
                var sum = 0;
                //for loop each node
                if (l1 != null)
                {
                    sum = sum + l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }

                sum = sum + carry;

                first.next = new ListNode(sum % 10);
                carry = (sum - first.next.val) / 10;

                first = first.next;

                index++;
            }


            return result.next;
        }
    }
}
