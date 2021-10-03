    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int ret = 0, diff = 999999;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int l = j + 1; l < nums.Length; l++)
                    {
                        if (Math.Abs(nums[i] + nums[j] + nums[l] - target) < diff)
                        {
                            ret = nums[i] + nums[j] + nums[l];
                            diff = Math.Abs(ret - target);
                        }
                    }
                }
            }
            return ret;
        }
    }