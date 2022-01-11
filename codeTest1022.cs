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
    public int SumRootToLeaf(TreeNode root)
    {
        return sum(root, 0);
    }
    public int sum(TreeNode root, int sumNum)
    {
        if (root == null) return 0;

        sumNum = 2 * sumNum + root.val;
        if (root.left == null && root.right == null) return sumNum;
        
        return sum(root.left, sumNum) + sum(root.left, sumNum);
    }
}