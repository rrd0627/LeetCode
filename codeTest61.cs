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
        if(k==1)return head;

        for (int i = 0; i < k; i++)
            head = RotateOnce(head);
        return head;
    }

    private ListNode RotateOnce(ListNode head)
    {
        ListNode firstNode = head;
        ListNode oldNode = null;
        ListNode curNode = head;
        ListNode newNode = head;

        while (curNode != null)
        {
            if (curNode.next == null)
            {//curNode가 마지막이다!
                newNode = new ListNode(curNode.val, firstNode);

                System.Console.WriteLine(curNode.val);

                oldNode.next = null;
                break;
            }
            oldNode = curNode;
            curNode = curNode.next;
        }
        return newNode;
    }
}