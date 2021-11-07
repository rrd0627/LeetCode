using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    int _target;
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> ret = new List<IList<int>>();

        _target = target;

        Array.Sort(candidates);

        dfs(0, 0, new List<int>(), ref ret, ref candidates);

        return ret;
    }

    private void dfs(int sum, int index, List<int> addList, ref List<IList<int>> retList, ref int[] candidates)
    {
        if (sum == _target)
        {
            retList.Add(addList);
            return;
        }
        if (sum > _target)
        {
            return;
        }
        for (int i = index; i < candidates.Length; i++)
        {
            List<int> newList = new List<int>();
            for (int j = 0; j < addList.Count; j++)
            {
                newList.Add(addList[j]);
            }
            newList.Add(candidates[i]);
            dfs(sum + candidates[i], i, newList, ref retList, ref candidates);
        }
    }
}