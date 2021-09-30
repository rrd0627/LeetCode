using System;
using System.Collections.Generic;
using System.Text;
public class Solution
{
    Dictionary<char, int> charToValue;
    public int RomanToInt(string s)
    {
        int ret = 0;
        int sSize = s.Length;
        charToValue = new Dictionary<char, int>();
        charToValue.Add('M', 1000);
        charToValue.Add('D', 500);
        charToValue.Add('C', 100);
        charToValue.Add('L', 50);
        charToValue.Add('X', 10);
        charToValue.Add('V', 5);
        charToValue.Add('I', 1);

        ret += charToValue[s[sSize - 1]];
        for (int i = sSize - 2; i >= 0; i--)
        {
            if (charToValue[s[i]] < charToValue[s[i + 1]])
            {
                ret -= charToValue[s[i]];
            }
            else
            {
                ret += charToValue[s[i]];
            }
        }
        return ret;
    }
}
