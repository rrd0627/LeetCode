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
            if (patternIndex == p.Length)
            {
                return false;
            }
            if (p[patternIndex] == '*') //연속된 별 처리!
            {
                while (patternIndex < p.Length && p[patternIndex] == '*')
                {
                    patternIndex++;
                }
                for (int j = i; j <= s.Length; j++)
                {
                    if (IsMatch(s.Substring(j), p.Substring(patternIndex)))
                    {
                        return true;
                    }
                }
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

        //남은게 모두 *이면 true
        while (patternIndex < p.Length && p[patternIndex] == '*')
        {
            patternIndex++;
        }

        return patternIndex >= p.Length;
    }
}