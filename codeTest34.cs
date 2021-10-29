using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] ret = new int[2] { -1, -1 };

        int leftIndex, rightIndex;

        int index = Array.BinarySearch<int>(nums, target);
        
        if(index<0)
        {
            return ret;
        }


        leftIndex = index; rightIndex = index;

        while (leftIndex >= 0 && nums[leftIndex] == target)
        {
            leftIndex--;
        }
        leftIndex++;

        while (rightIndex < nums.Length && nums[rightIndex] == target)
        {
            rightIndex++;
        }
        rightIndex--;

        ret[0] = leftIndex;
        ret[1] = rightIndex;

        return ret;
    }
}