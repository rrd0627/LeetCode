using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    int[][] dp;
    int[] newNums;
    public int MaxCoins(int[] nums)
    {
        newNums = new int[nums.Length + 2];
        for (int i = 0; i < nums.Length; i++)
        {
            newNums[i + 1] = nums[i];
        }
        newNums[0] = newNums[newNums.Length - 1] = 1;
        dp = new int[newNums.Length][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[newNums.Length];
        }

        return func(0, newNums.Length - 1);
    }
    int func(int left, int right)
    {
        if (left + 1 == right) return 0;

        if (dp[left][right] != 0) return dp[left][right];

        int ret = 0;
        for (int i = left + 1; i < right; i++)
        {
            ret = Math.Max(ret, newNums[left] * newNums[i] * newNums[right] + func(left,i) + func(i,right));
        }
        dp[left][right] = ret;
        return ret;
    }
}