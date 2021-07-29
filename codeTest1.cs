using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> hashtable = new Dictionary<int, int>();

        int arrLen = nums.Length;

        for (int i = 0; i < arrLen; i++)
        {
            if (hashtable.ContainsKey(target - nums[i])) return new int[] { hashtable[target - nums[i]], i };
            hashtable[nums[i]] = i;
        }
        return new int[] { 0, 0 };
    }
}