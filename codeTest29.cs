using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution {
    public int Divide(int dividend, int divisor) {
        int ret = int.MaxValue;

        if(dividend == int.MinValue && divisor == -1)return ret;

        ret = dividend / divisor;

        return ret;
    }
}