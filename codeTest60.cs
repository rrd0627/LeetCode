using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public string GetPermutation(int n, int k)
    {
        List<int> nums = new List<int>(n);
        for (int i = 0; i < n; i++)
            nums.Add(i + 1);

        int nfact = 1;
        for (int i = 1; i <= n; i++)
            nfact *= i;

        string ret = "";

        int blockSize = nfact;
        int curIndex = k;
        int blockIndex = 0;
        while (nums.Count > 0)
        {
            //블럭을 쪼개기
            blockSize = blockSize / n;

            //쪼갠 블럭중 몇번째 블럭인지
            blockIndex = Math.Clamp((curIndex - 1) / blockSize, 0, blockSize);

            //몇번째 블럭인지를 토대로 ret작성
            ret += nums[blockIndex].ToString();
            nums.RemoveAt(blockIndex);

            //다음을 위해서 
            n--;
            curIndex = (curIndex - 1) % blockSize;
        }
        return ret;
    }
}