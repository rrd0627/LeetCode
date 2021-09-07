using System;
using System.Collections.Generic;
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> hash = new HashSet<char>();
        int startIndex = 0;
        int lastIndex = 0;
        int ret = 0;
        int strLength = s.Length;

        while (lastIndex < s.Length)
        {
            if (!hash.Contains(s[lastIndex]))
            {//안겹치면
                hash.Add(s[lastIndex]);
                lastIndex++;
                ret = Math.Max(ret, lastIndex - startIndex);
                continue;
            }
            //겹치면
            hash.Remove(s[startIndex]);
            startIndex++;
        }
        return ret;
    }
}