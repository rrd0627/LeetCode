using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public bool IsMatch(string s, string p)
    {
        int patternIndex = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if(patternIndex == p.Length)return false; 
            if (p[patternIndex] == '*')
            {
                patternIndex++;
                if (IsMatch(s.Substring(i + 1), p.Substring(patternIndex))) return true;
            }
            else if (s[i] == p[patternIndex] || p[patternIndex] == '?')
            {
                patternIndex++;
            }
            else
            {
                return false;
            }
        }

        return patternIndex >= p.Length;
    }
}