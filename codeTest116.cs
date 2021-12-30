using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


// Definition for a Node.
public class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}


public class Solution
{
    Queue<Node> nodes = new Queue<Node>();
    public Node Connect(Node root)
    {
        if (root == null) return root;
        nodes.Enqueue(root);
        while (nodes.Count > 0)
        {
            Node curNode = nodes.Dequeue();
            System.Console.WriteLine(curNode.val);

            Node leftNode = curNode.left;
            Node rightNode = curNode.right;


            if (leftNode != null)
            {
                leftNode.next = rightNode;
                if (curNode.next != null)
                    rightNode.next = curNode.next.left;

                nodes.Enqueue(leftNode);
                nodes.Enqueue(rightNode);
            }
        }
        return root;
    }
}