using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int MinPathSum(int[][] grid)
    {
        int[] dp = new int[grid[0].Length];

        dp[0] = grid[0][0];

        for (int i = 1; i < dp.Length; i++)
        {
            dp[i] = dp[i - 1] + grid[0][i];
        }

        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (j == 0) dp[0] += grid[i][0];
                else
                {
                    dp[j] = Math.Min(dp[j - 1] + grid[i][j], dp[j] + grid[i][j]);
                }
            }
        }
        return dp[dp.Length - 1];

    }
}