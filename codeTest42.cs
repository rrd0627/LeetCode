using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int Trap(int[] height)
    {
        if (height.Length == 1) return 0;
        int[] leftMax = new int[height.Length];
        int[] rightMax = new int[height.Length];

        List<int> pointIndex = new List<int>();
        //꼭지점 구하기
        if (height[0] > height[1]) pointIndex.Add(0);
        for (int i = 1; i < height.Length - 1; i++)
        {
            if (height[i] > height[i - 1] && height[i] > height[i + 1])
            {
                pointIndex.Add(i);
            }
        }
        if (height[height.Length - 1] > height[height.Length - 2]) pointIndex.Add(height.Length - 1);

        //모든 위치에서 왼쪽 높은 벽 오른쪽 높은벽 각각 구하기
        int left = 0;
        int right = 0;
        for (int i = 0; i < pointIndex.Count - 1; i++)
        {
            left = Math.Max(left, height[pointIndex[i]]);
            for (int j = pointIndex[i]; j <= pointIndex[i + 1]; j++)
            {
                leftMax[j] = left;
            }
        }
        for (int i = pointIndex.Count - 2; i >= 0; i--)
        {
            right = Math.Max(right, height[pointIndex[i]]);
            for (int j = pointIndex[i]; j <= pointIndex[i + 1]; j++)
            {
                rightMax[j] = right;
            }
        }

        int ret = 0;
        //모든위치에서 왼쪽벽 오른쪽벽에 따라 구하기
        for (int i = 0; i < height.Length; i++)
        {
            int min = Math.Min(leftMax[i], rightMax[i]);
            if (min - height[i] != 0) System.Console.WriteLine($"index {i} value {min}");
            ret += (min - height[i]);
        }
        return ret;
    }
}