using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int SmallestRepunitDivByK(int k)
    {
        int oneInt = 0;
        int retLength = 0;
        for (int i = 0; i < k; i++)
        {
            retLength++;
            int n = oneInt * 10 + 1;
            oneInt = n % k;
            if (oneInt == 0) return retLength;
        }
        return -1;
    }
}
