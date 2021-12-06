using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int curIndex = s.Length - 1;

        while (s[curIndex] == ' ')
        {
            curIndex--;
        }
        int ret = curIndex;
        while (curIndex >= 0 && s[curIndex] != ' ')
        {
            curIndex--;
        }
        return ret - curIndex;
    }
}