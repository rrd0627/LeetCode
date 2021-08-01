using System;
using System.Collections.Generic;
public class Solution
{
    public int Reverse(int x)
    {
        if (x > 0)
        {
            char[] charArray = x.ToString().ToCharArray();
            Array.Reverse(charArray);

            if (charArray.Length >= 10)
            {
                if (int.TryParse(charArray, out int result))
                {
                    return result;
                }
                else
                    return 0;
            }
            return int.Parse(charArray);
        }
        else
        {
            x = -x;
            char[] charArray = x.ToString().ToCharArray();
            Array.Reverse(charArray);
            if (charArray.Length >= 10)
            {
                if (int.TryParse(charArray, out int result))
                {
                    return -result;
                }
                else
                    return 0;
            }
            return -int.Parse(charArray);
        }
    }
}