using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int Jump(int[] nums)
    {
        int[] minCache = new int[nums.Length];

        for (int i = 0; i < minCache.Length; i++)
            minCache[i] = int.MaxValue;
        minCache[0] = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j <= nums[i]; j++)
            {
                if (i + j >= nums.Length) continue;
                minCache[i + j] = Math.Min(minCache[i + j], minCache[i] + 1);
            }
        }


        return minCache[nums.Length - 1];
    }
}