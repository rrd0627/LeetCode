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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode retList = new ListNode();
        ListNode nodeHanlder = retList;


        while (l1 != null && l2 != null)
        {
            if (l1.val >= l2.val)
            {
                nodeHanlder.next = l2;
                l2 = l2.next;
            }
            else
            {
                nodeHanlder.next = l1;
                l1 = l1.next;
            }
            nodeHanlder = nodeHanlder.next;
        }
        
        if (l1 != null)
        {
            nodeHanlder.next = l1;
        }
        else if (l2 != null)
        {
            nodeHanlder.next = l2;
        }

        return retList.next;
    }
}