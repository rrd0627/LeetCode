using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        char[] curChars;

        Dictionary<string, int> strToIndex = new Dictionary<string, int>();

        int strKey = 0;

        List<IList<string>> ret = new List<IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            curChars = strs[i].ToArray();
            Array.Sort(curChars);
            string curStr = new string(curChars);

            if (strToIndex.TryGetValue(curStr, out int curIndex))
            {
                ret[curIndex].Add(strs[i]);
            }
            else
            {
                List<string> tempRet = new List<string>();
                tempRet.Add(strs[i]);
                strToIndex.Add(curStr, strKey);
                ret.Add(tempRet);
                strKey++;
            }
        }
        return ret;
    }
}