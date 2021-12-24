using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution {
    public int MySqrt(int x) {
        long r = x;
        while (r*r > x)
            r = (r + x/r) / 2;
        return (int)r;
    }
}