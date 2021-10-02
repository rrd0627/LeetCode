using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> ret = new List<IList<int>>();
        if (nums.Length <= 2) return ret;
        Array.Sort(nums);
        int left, right;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int target = -nums[i];
            left = i + 1;
            right = nums.Length - 1;

            while (left < right)
            {
                if (nums[left] + nums[right] > target)
                {
                    right--;
                }
                else if (nums[left] + nums[right] < target)
                {
                    left++;
                }
                else
                {
                    ret.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    left++;
                    while (left < right && nums[left - 1] == nums[left])
                    {
                        left++;
                    }
                }
            }
        }
        return ret;
    }
}