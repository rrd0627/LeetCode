using System;
using System.Collections.Generic;
public class Solution
{
    public string LongestPalindrome(string str)
    {
        if (str.Length < 1)
        {
            return str;
        }
        string ret = str[0].ToString();
        string retTemp;
        string tempRet1, tempRet2;
        for (int i = 0; i < str.Length; i++)
        {
            tempRet1 = Compare(str, i, i + 1);            
            tempRet2 = Compare(str, i - 1, i + 1);

            retTemp = tempRet1.Length > tempRet2.Length ? tempRet1 : tempRet2;

            if (retTemp.Length > ret.Length)
            {
                ret = retTemp;
            }
        }
        return ret;
    }

    private string Compare(string str, int startIndex, int lastIndex)
    {
        if (startIndex < 0 || lastIndex >= str.Length)
        {
            return "";
        }
        while (startIndex >= 0 && lastIndex < str.Length && str[startIndex] == str[lastIndex])
        {
            startIndex--;
            lastIndex++;
        }
        return str.Substring(startIndex + 1, lastIndex - startIndex - 1);
    }
}