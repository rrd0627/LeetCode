using System;
using System.Collections.Generic;
public class Solution
{
    char[,] charBuffer;
    public string Convert(string s, int numRows)
    {
        char[] answer = new char[s.Length];
        int charIndex = -1, charLength = 0; ;
        for (int i = 0; i < s.Length; i++)
        {
            charIndex++;
            if (charIndex * (numRows * 2 - 2) + charLength >= s.Length)
            {
                charIndex = 0;
                charLength++;
            }
            Console.WriteLine(charIndex * (numRows * 2 - 2) + charLength);
            answer[i] = s[charIndex * (numRows * 2 - 2) + charLength];
        }
        string answerStr = new string(answer);
        return answerStr;
    }
}