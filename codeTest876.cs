using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
    public ListNode MiddleNode(ListNode head)
    {
        List<ListNode> listNodes = new List<ListNode>();

        while (head != null)
        {
            listNodes.Add(head);
            head = head.next;
        }

        return listNodes[listNodes.Count / 2];
    }
}