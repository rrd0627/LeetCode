using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    int[] dp;
    public int ClimbStairs(int n)
    {
        dp = new int[n + 1];
        return func(n);
    }
    int func(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 2;
        if (dp[n] != 0) return dp[n];
        dp[n] = func(n - 1) + func(n - 2);
        return dp[n];
    }
}