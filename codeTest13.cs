using System;
using System.Collections.Generic;
using System.Text;
public class Solution
{
    Dictionary<string, int> strToValue;
    public int RomanToInt(string s)
    {
        int ret = 0;
        strToValue = new Dictionary<string, int>();
        strToValue.Add("M", 1000);
        strToValue.Add("CM", 900);
        strToValue.Add("D", 500);
        strToValue.Add("CD", 400);
        strToValue.Add("C", 100);
        strToValue.Add("XC", 90);
        strToValue.Add("L", 50);
        strToValue.Add("XL", 40);
        strToValue.Add("X", 10);
        strToValue.Add("IX", 9);
        strToValue.Add("V", 5);
        strToValue.Add("IV", 4);
        strToValue.Add("I", 1);

        while (s.Length > 0)
        {
            if(s.Length==1)
            {
                ret += strToValue[s.Substring(0,1)];
                break;
            }
            if(strToValue.TryGetValue(s.Substring(0, 2),out int value))
            {
                s=s.Substring(2);
                ret += value;
            }
            else
            {
                ret += strToValue[s.Substring(0,1)];
                s=s.Substring(1);
            }
        }
        return ret;
    }
}
