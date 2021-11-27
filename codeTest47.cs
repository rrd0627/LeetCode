using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace codeTest47
{
    public class Solution
    {
        List<IList<int>> ret = new List<IList<int>>();

        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);

            func(nums.ToList(), new List<int>());

            return ret;
        }

        private void func(List<int> leftNums, List<int> retNums)
        {
            if (leftNums.Count == 0)
            {
                ret.Add(retNums);
            }
            int prevNum = int.MaxValue;
            for (int i = 0; i < leftNums.Count; i++)
            {
                if (prevNum == leftNums[i]) continue;
                prevNum = leftNums[i];
                List<int> newNums = new List<int>(leftNums);
                newNums.Remove(leftNums[i]);
                List<int> newRetNums = new List<int>(retNums);
                newRetNums.Add(leftNums[i]);
                func(newNums, newRetNums);
            }
        }
    }
}
