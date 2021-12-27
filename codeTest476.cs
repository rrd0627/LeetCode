using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int FindComplement(int num)
    {
        uint ret = 1;
        while (ret <= num)
        {
            ret = ret << 1;
        }
        return (int)ret - num - 1;
    }
}