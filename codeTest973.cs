using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    private int comp(int[] pointA, int[] pointB)
    {
        float distA = pointA[0] * pointA[0] + pointA[1] * pointA[1];
        float distB = pointB[0] * pointB[0] + pointB[1] * pointB[1];

        if (distA < distB)
        {
            return -1;
        }
        else if (distA > distB)
        {
            return 1;
        }
        return 0;
    }
    public int[][] KClosest(int[][] points, int k)
    {
        int[][] retArr = new int[k][];

        Array.Sort(points, comp);

        for (int i = 0; i < k; i++)
        {
            retArr[i] = points[i];
        }
        return retArr;
    }
}