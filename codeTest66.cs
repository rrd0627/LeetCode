using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i]++;
                return digits;
            }
            else
            {
                digits[i] = 0;
                if (i == 0)
                {
                    int[] ret = new int[digits.Length + 1];
                    ret[0] = 1;
                    return ret;
                }
            }
        }
        return digits;
    }
}