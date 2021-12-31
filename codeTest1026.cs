using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

// Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int MaxAncestorDiff(TreeNode root)
    {
        return func(root, int.MaxValue, int.MinValue);
    }
    int func(TreeNode root, int min, int max)
    {
        if (root == null)
        {
            return Math.Abs(min - max);
        }

        if (root.val < min)
        {
            min = root.val;
        }
        if (root.val > max)
        {
            max = root.val;
        }

        return Math.Max(func(root.left, min, max), func(root.right, min, max));
    }
}