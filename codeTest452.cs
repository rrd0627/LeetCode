using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (x, y) => (x[1].CompareTo(y[1])));
        int ret = 1;
        int curpos = points[0][1];
        for (int i = 1; i < points.Length; i++)
        {
            if (curpos < points[i][0])
            {
                curpos = points[i][1];
                ret++;
            }
        }
        return ret;
    }
}