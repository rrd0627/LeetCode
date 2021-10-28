using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int lo = 0, hi = nums.Length - 1;

        while (lo < hi)
        {
            int mid = (lo + hi) / 2;
            if (nums[mid] > nums[hi]) lo = mid + 1;
            else hi = mid;
        }

        //lo == hi == 처음시작자리

        int startIndex = lo;
        lo = 0; hi = nums.Length - 1;

        while (lo <= hi)
        {
            int mid = (lo + hi) / 2;
            int realmid = (mid + startIndex) % nums.Length;
            if (nums[realmid] == target) return realmid;
            if (nums[realmid] < target) lo = mid + 1;
            else hi = mid - 1;
        }
        return -1;
    }
}