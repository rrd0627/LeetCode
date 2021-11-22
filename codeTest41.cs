using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        Array.Sort(nums);
        int ret = 1;

        int startIndex = 0;
        for (startIndex = 0; startIndex < nums.Length; startIndex++)
        {
            if (nums[startIndex] > 0) break;
        }

        for (int i = startIndex; i < nums.Length; i++)
        {
            if (nums[i] == ret)
            {
                ret++;
            }
            else if(nums[i] > ret)
            {
                return ret;
            }
            else
            {
                continue;
            }
        }

        return ret;
    }

}