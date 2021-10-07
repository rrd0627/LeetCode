using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        List<IList<int>> ret = new List<IList<int>>();

        if (nums.Length <= 3) return ret;
        Array.Sort(nums);

        int left, right;
        bool isAddI = false,isAddJ = false;
        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1] && isAddI) continue;
            isAddI = false;
            isAddJ = false;
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > 1 && nums[j] == nums[j - 1] && isAddJ)
                {
                    continue;
                }
                isAddJ = false;
                left = j + 1;
                right = nums.Length - 1;

                while (left < right)
                {
                    if (nums[i] + nums[j] + nums[left] + nums[right] > target)
                    {
                        right--;
                    }
                    else if (nums[i] + nums[j] + nums[left] + nums[right] < target)
                    {
                        left++;
                    }
                    else
                    {
                        ret.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                        left++;
                        isAddI = true;
                        isAddJ = true;
                        while (left < right && nums[left - 1] == nums[left])
                        {
                            left++;
                        }
                    }
                }
            }
        }

        return ret;
    }
}