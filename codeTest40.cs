using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    int _length, _target;
    List<IList<int>> ret;
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);

        ret = new List<IList<int>>();

        _length = candidates.Length;
        _target = target;

        func(ref candidates, 0, new List<int>(), 0);

        return ret;

    }

    private void func(ref int[] candidates, int curIndex, List<int> list, int sum)
    {

        if (_target == sum)
        {
            ret.Add(new List<int>(list));
            return;
        }

        if (_target < sum || curIndex >= _length)
        {
            return;
        }
        
        int nextIndex = curIndex + 1;

        while (nextIndex < _length && candidates[curIndex] == candidates[nextIndex])
        {
            nextIndex++;
        }

        for (int i = 0; i < nextIndex - curIndex + 1; i++)
        {
            int newSum = 0;

            for (int j = 0; j < i; j++)
            {
                list.Add(candidates[curIndex + j]);
                newSum += candidates[curIndex + j];
            }

            func(ref candidates, nextIndex, list, sum + newSum);

            for (int j = 0; j < i; j++)
            {
                list.Remove(candidates[curIndex + j]);
            }
        }
    }
}