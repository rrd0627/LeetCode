using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        HashSet<int> NotAnswerSet = new HashSet<int>();

        int[] answerArr = new int[n + 1];

        for (int i = 0; i < trust.Length; i++)
        {
            NotAnswerSet.Add(trust[i][0]);
            answerArr[trust[i][1]]++;
        }

        for (int i = 1; i <= n; i++)
        {
            if (answerArr[i] == n - 1)
            {
                if (!NotAnswerSet.Contains(i))
                {
                    return i;
                }
            }
        }
        return -1;
    }
}