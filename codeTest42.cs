using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int Trap(int[] height)
    {
        int ret = 0;
        int temp = 0;
        int[] leftMax = new int[height.Length];
        int[] rightMax = new int[height.Length];
        int left = 0;
        int right = 0;
        for (int i = 0; i < height.Length; i++)
        {
            left = Math.Max(left, height[i]);
            leftMax[i] = left;
        }
        for (int i = height.Length - 1; i >= 0; i--)
        {
            right = Math.Max(right, height[i]);
            rightMax[i] = right;
        }

        for (int i = 0; i < height.Length; i++)
        {
            temp = Math.Min(leftMax[i], rightMax[i]) - height[i];
            if (temp > 0)
                ret += temp;
        }
        return ret;
    }
}