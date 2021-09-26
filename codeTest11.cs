using System;
using System.Collections.Generic;
public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int answer = 0;

        while (left < right)
        {
            int min = Math.Min(height[left], height[right]);
            min *= right - left;

            if (answer < min)
            {
                answer = min;
            }

            //left 가 작으면 left를 옮기고            
            //right가 작으면 right를 옮김
            if (height[left] < height[right])
            {
                int leftSize = height[left];
                while (left < right)
                {
                    left++;
                    if (leftSize < height[left])
                    {
                        break;
                    }
                }
            }
            else
            {
                int rightSize = height[right];
                while (left < right)
                {
                    right--;
                    if (rightSize < height[right])
                    {
                        break;
                    }
                }
            }
        }
        return answer;
    }
}