using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int NumPairsDivisibleBy60(int[] time)
    {
        int[] arr = new int[60];

        for (int i = 0; i < time.Length; i++)
        {
            arr[time[i] % 60]++;
        }

        int ret = 0;

        for (int i = 1; i < 30; i++)
        {
            ret += arr[i] * arr[60 - i];
        }

        if (arr[0] >= 2)
        {
            ret += (arr[0] * (arr[0] - 1)) / 2;
        }
        if (arr[30] >= 2)
        {
            ret += (arr[30] * (arr[30] - 1)) / 2;
        }
        return ret;
    }
}