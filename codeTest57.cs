using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int comp(int[] x, int[] y)
    {
        if (x[0] == y[0])
        {
            if (x[1] < y[1]) return -1;
            else return 1;
        }
        if (x[0] < y[0]) return -1;
        return 1;

    }
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> ret = new List<int[]>();

        int[] newArr = new int[2];
        Array.Sort(intervals, comp);

        int left = newInterval[0];
        int right = newInterval[1];

        for (int i = 0; i < intervals.Length; i++)
        {
            //포함됨
            if (left <= intervals[i][1] && right >= intervals[i][0])
            {
                left = Math.Min(left, intervals[i][0]);
                right = Math.Max(right, intervals[i][1]);

                newArr[0] = left;
                newArr[1] = right;
            }
            //포함안됨
            else
            {
                ret.Add(intervals[i]);
            }
        }
        ret.Add(new int[] { left, right });

        int[][] realRet = ret.ToArray();
        Array.Sort(realRet, comp);

        return realRet;
    }
}