using System;
using System.Collections.Generic;
public class Solution
{
    char[,] charBuffer;
    public string Convert(string s, int numRows)
    {
        charBuffer = new char[1001, 1001];
        int x = 0, y = 0;
        bool isZigZaging = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (y < 0) y = 0;
            charBuffer[y, x] = s[i];

            if (isZigZaging)
            {
                if (y == 0)
                {
                    isZigZaging = false;
                    y++;
                    if (y >= numRows)
                    {
                        isZigZaging = true;
                        x++;
                        y--;
                    }
                }
                else
                {
                    y--;
                    x++;
                }
            }
            else
            {
                if (y >= numRows-1)
                {
                    isZigZaging = true;
                    x++;
                    y--;
                }
                else
                {
                    y++;
                }
            }
        }
        char[] answer = new char[1001];

        int charIndex = 0;
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < x + 1; j++)
            {
                if (charBuffer[i, j] != 0)
                {
                    answer[charIndex++] = charBuffer[i, j];
                }
            }
        }
        Array.Resize<char>(ref answer, charIndex);
        string answerStr = new string(answer);
        return answerStr;
    }
}