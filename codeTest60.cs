using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public string GetPermutation(int n, int k)
    {
        List<int> nums = new List<int>();
        nums.AddRange(Enumerable.Range(1, n));

        int nfact = 1;
        for (int i = 1; i <= n; i++)
            nfact *= i;

        StringBuilder ret = new StringBuilder();

        int blockSize = nfact;
        int curIndex = k - 1;
        int blockIndex = 0;
        while (nums.Count > 0)
        {
            //블럭을 쪼개기
            blockSize = blockSize / n;

            //쪼갠 블럭중 몇번째 블럭인지
            blockIndex = curIndex / blockSize;

            //몇번째 블럭인지를 토대로 ret작성
            ret.Append(nums[blockIndex]);
            nums.RemoveAt(blockIndex);

            //다음을 위해서 
            n--;
            curIndex = curIndex % blockSize;
        }
        return ret.ToString();
    }
}