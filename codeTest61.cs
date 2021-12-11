using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


//Definition for singly - linked list.
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
    public ListNode RotateRight(ListNode head, int k)
    {
        List<ListNode> lists = new List<ListNode>();

        if (head == null || head.next == null || k == 0)
            return head;

        while (head != null)
        {
            lists.Add(head);
            head = head.next;
        }

        int kMod = k % lists.Count;

        if (kMod == 0)
        {
            return lists[0];
        }

        //떼는곳
        lists[lists.Count - kMod - 1].next = null;

        //마지막
        lists[lists.Count - 1].next = lists[0];

        return lists[lists.Count - kMod];
    }
}