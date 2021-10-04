using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int ret = 0, diff = 999999;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;

            int sum;
            while (left < right)
            {
                sum = nums[i] + nums[left] + nums[right];

                if (Math.Abs(sum - target) < diff)
                {
                    ret = sum;
                    diff = Math.Abs(sum - target);
                }

                if (sum > target)
                {
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    return ret;
                }
            }
        }
        return ret;
    }
}