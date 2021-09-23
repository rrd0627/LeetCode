using System;
using System.Collections.Generic;
public class Solution
{
    public int MyAtoi(string s)
    {
        if (s.Length <= 0) return 0;

        //1. space
        int charIndex = 0;
        while (s[charIndex] == ' ')
        {
            charIndex++;
            if (charIndex >= s.Length) return 0;
        }

        //2. + -
        bool isNegative = false;
        if (s[charIndex] == '+')
        {
            charIndex++;
        }
        else if (s[charIndex] == '-')
        {
            isNegative = true;
            charIndex++;
        }



        //3. non digit
        s = s.Substring(charIndex);
        charIndex = 0;
        if (charIndex >= s.Length) return 0;
        while (s[charIndex] >= '0' && s[charIndex] <= '9')
        {
            charIndex++;
            if (charIndex >= s.Length) break;
        }
        s = s.Substring(0, charIndex);

        if(s.Length<=0)return 0;

        if (isNegative)
        {
            s = "-" + s;
        }

        //4. integer Clamp        
        if (!int.TryParse(s, out int result))
        {
            if(isNegative)result = int.MinValue;
            else result = int.MaxValue;
        }
        return result;
    }
}