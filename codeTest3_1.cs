using System;
using System.Collections.Generic;
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int startIndex = 0;
        int lastIndex = 0;
        int ret = 0;
        int strLength = s.Length;
        int sameIndex;
        while (lastIndex < s.Length)
        {
            if (!dic.ContainsKey(s[lastIndex]))
            {//안겹치면
                dic.Add(s[lastIndex], lastIndex);
                lastIndex++;
                ret = Math.Max(ret, lastIndex - startIndex);
                continue;
            }
            //겹치면

            //겹치는 위치
            sameIndex = dic[s[lastIndex]];
            for (int i = startIndex; i <= sameIndex; i++)
            {
                dic.Remove(s[i]);
            }
            startIndex = sameIndex + 1;
        }
        return ret;
    }
}