using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public bool CanJump(int[] nums)
    {
        int maxIndex = 0;

        for (int i = 0; i <= maxIndex; i++)
        {
            if (maxIndex >= nums.Length - 1)
            {
                return true;
            }
            maxIndex = Math.Max(maxIndex, i + nums[i]);
        }
        return false;
    }
}