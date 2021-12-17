using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        char[] newStr = new char[(int)MathF.Max(a.Length, b.Length) + 1];

        a = a.Reverse();
        b = b.Reverse();

        for (int i = 0; i < newStr.Length; i++)
        {
            int sum = 0;
            if (newStr[i] == '1') sum++;

            if (i < a.Length)
            {
                if (a[i] == '1') sum++;
            }
            if (i < b.Length)
            {
                if (b[i] == '1') sum++;
            }

            if (sum == 0)
                newStr[i] = '0';
            else if (sum == 1)
                newStr[i] = '1';
            else
            {
                newStr[i] = '0';
                newStr[i + 1] = '1';
            }
        }
        newStr = newStr.Reverse();

        string retStr = new string(newStr);
        return retStr;
    }
}