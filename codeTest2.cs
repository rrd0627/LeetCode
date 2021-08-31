using System;
using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode answer = new ListNode();
        ListNode node = answer;
        int val = 0;
        int carry = 0;
        while (l1 != null || l2 != null)
        {
            val = carry;
            if (l1 != null)
            {
                val += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                val += l2.val;
                l2 = l2.next;
            }
            if (val >= 10)
            {
                val -= 10;
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            ListNode temp = new ListNode(val);
            node.next = temp;
            node = node.next;
        }
        if (carry > 0)
        {
            ListNode temp = new ListNode(carry);
            node.next = temp;
        }
        return answer.next;
    }
}