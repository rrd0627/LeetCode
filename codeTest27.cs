using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums == null || nums.Length == 0) return 0;

        int ret = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[ret] = nums[i];
                ret++;
            }
        }

        return ret;
    }
}