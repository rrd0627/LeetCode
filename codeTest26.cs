using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null || nums.Length ==0 )return 0;
        int ret=0;

        int cur=int.MinValue;

        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=cur)
            {
                cur = nums[i];
                nums[ret] = cur;
                ret++;
            }
        }
        return ret;
    }
}