using System;
using System.Collections.Generic;
using System.Text;
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> ret = new List<IList<int>>();
        Dictionary<int, List<int>> valueToIndex = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            List<int> list = new List<int>();
            valueToIndex.TryGetValue(nums[i],out list);            
            list.Add(i);
            valueToIndex.Add(nums[i], list);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int firstValue = (int)nums[i];

            for (int j = i + 1; j < (int)nums.Length; j++)
            {
                int secondValue = nums[j];

                List<int> indexList = valueToIndex[-firstValue - secondValue];

                for (int l = 0; l < indexList.Count; l++)
                {
                    List<int> retTemp = new List<int>();
                    retTemp.Add(1);
                    ret.Add(retTemp);
                }
            }
        }

        return ret;
    }
}