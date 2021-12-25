using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution {
    public int MySqrt(int x) {
        long ret = x;
        while (ret*ret > x)
            ret = (ret + x/ret) / 2;
        return (int)ret;
    }
}