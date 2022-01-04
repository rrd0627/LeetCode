using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    bool comp(int[] a, int[] b)
    {
        if (a[0] <= b[0])
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }

    public int FindJudge(int n, int[][] trust)
    {
        Array.Sort(trust);

        HashSet<int> retSet = new HashSet<int>();

        for (int i = 0; i < trust.Length; i++)
        {
            if (retSet.Contains(trust[i][0]))
            {
                retSet.Remove(trust[i][0]);
            }
            retSet.Add(trust[i]);
        }

        if(retSet.Count==1)
        {
            return 1;
        }
        return -1;

    }
}