using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


//Definition for singly-linked list.
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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if(head.next == null)
        {
            return null;
        }

        ListNode[] listArr = new ListNode[31];

        ListNode curNode = head;

        int curIndex = 0;

        while (curNode != null)
        {
            listArr[curIndex++] = curNode;
            curNode = curNode.next;
        }

        //맨앞을 없애는경우
        if (curIndex - n - 1 < 0)
        {
            head = head.next;
        }
        else
        {
            listArr[curIndex - n - 1].next = listArr[curIndex - n + 1];
        }



        return head;
    }
}