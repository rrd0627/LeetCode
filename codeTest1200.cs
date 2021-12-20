using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);

        List<IList<int>> ret = new List<IList<int>>();

        List<int> curList;

        int minAbsDiff = int.MaxValue;

        for (int i = 1; i < arr.Length; i++)
        {
            int diff = arr[i] - arr[i - 1];

            if (diff < minAbsDiff)
            {
                //새로 해야댐
                minAbsDiff = diff;

                ret.Clear();

                curList = new List<int>() { arr[i - 1], arr[i] };

                ret.Add(curList);
            }
            else if (diff == minAbsDiff)
            {
                //같은건 ret에 더해주기
                curList = new List<int>() { arr[i - 1], arr[i] };

                ret.Add(curList);
            }
        }
        return ret;
    }
}