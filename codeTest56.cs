using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int comp(int[] x,int[] y)
    {
        if (x[0] == y[0])
        {
            if (x[1] < y[1]) return -1;
            else return 1;
        }
        if (x[0] < y[0]) return -1;
                return 1;

    }

    public int[][] Merge(int[][] intervals)
    {
        List<int[]> lists = new List<int[]>();

        Array.Sort(intervals, comp);

        int curIndex = 0;
        int from = 0;
        int lastValue = intervals[curIndex][1];

        while (curIndex < intervals.Length)
        {
            if (lastValue >= intervals[curIndex][0])
            {//포함되면

                //뒤에값 늘려주고
                lastValue = Math.Max(lastValue, intervals[curIndex][1]);

            }
            else
            {
                //포함안되면

                //여태까지 아이들 넣어주고
                int[] newArra = new int[] { intervals[from][0], lastValue };
                lists.Add(newArra);

                // 새로운시작
                from = curIndex;
                lastValue = intervals[curIndex][1];
            }
            curIndex++;
        }
        //마지막꺼 넣어주기
        int[] newArrb = new int[2] { intervals[from][0], lastValue };
        lists.Add(newArrb);

        return lists.ToArray();
    }
}