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
        int val = 0, carry = 0;
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

            node.val = val % 10;
            if (l1 != null || l2 != null)
            {
                ListNode temp = new ListNode();
                node.next = temp;
                node = temp;
            }



            carry = 0;
            if (val >= 10)
            {
                carry = 1;
            }
        }
        if (carry > 0)
        {
            ListNode temp = new ListNode(carry);
            node.next = temp;
        }
        return answer;
    }
}