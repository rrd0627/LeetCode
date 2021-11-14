using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int maxSubArray = nums[0];
        int ret = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            maxSubArray = Math.Max(maxSubArray + nums[i], nums[i]);
            ret = Math.Max(ret, maxSubArray);
        }
        return ret;
    }
}