using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        int maxLength = Math.Max(a.Length, b.Length);

        int numA;
        int numB;
        int sum;
        int carry = 0;

        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < maxLength; i++)
        {
            if (i < a.Length)
            {
                numA = a[a.Length - 1 - i] == '0' ? 0 : 1;
            }
            else
                numA = 0;
            if (i < b.Length)
            {
                numB = b[b.Length - 1 - i] == '0' ? 0 : 1;
            }
            else
                numB = 0;
            sum = numA + numB + carry;

            if (sum == 0)
            {
                stringBuilder.Insert(0, "0");
                carry = 0;
            }
            else if (sum == 1)
            {
                stringBuilder.Insert(0, "1");
                carry = 0;
            }
            else if (sum == 2)
            {
                stringBuilder.Insert(0, "0");
                carry = 1;
            }
            else if (sum == 3)
            {
                stringBuilder.Insert(0, "1");
                carry = 1;
            }
        }
        if (carry == 1) stringBuilder.Insert(0, "1");
        return stringBuilder.ToString();
    }
}