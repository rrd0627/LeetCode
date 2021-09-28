using System;
using System.Collections.Generic;
using System.Text;
public class Solution
{
    int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    String[] strs = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    public string IntToRoman(int num)
    {
        StringBuilder ret = new StringBuilder();
        int valuesLength = values.Length;
        while (num > 0)
        {
            for (int i = 0; i < valuesLength; i++)
            {
                if (num >= values[i])
                {
                    num -= values[i];
                    ret.Append(strs[i]);
                    break;
                }
            }
        }
        return ret.ToString();
    }
}