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

        int startIndex = 0;
        int length = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str.Substring(i - length, length + 1) == Reverse(str.Substring(i - length, length + 1).ToCharArray())) //두개짜리!
            {
                startIndex = i - length;
                length++;
            }
            else if (i - length > 0 && str.Substring(i - length - 1, length + 2) == Reverse(str.Substring(i - length - 1, length + 2))) //두개씩 같은것!
            {
                startIndex = i - length - 1;
                length += 2;
            }
        }
        return str.Substring(startIndex, length);
    }
    static string Reverse(string text)
    {
        char[] charArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            reverse += charArray[i];
        }
        return reverse;
    }
}