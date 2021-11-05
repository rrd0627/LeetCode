using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    string[] cache;
    public string CountAndSay(int n)
    {
        cache = new string[n + 1];
        cache[1] = "1";

        for (int i = 2; i <= n; i++)
        {
            solve(i);
        }
        return cache[n];
    }

    void solve(int n)
    {
        string lastStr = cache[n - 1];

        int strIndex = 0;
        char curChar = lastStr[strIndex];
        char nextChar;
        int repeatNum = 1;
        System.Console.WriteLine($"{lastStr}");

        while (lastStr.Length - 1 > strIndex)
        {
            nextChar = lastStr[strIndex + 1];
            System.Console.WriteLine($"{n} {nextChar}");
            if (nextChar != curChar)
            {//다음 숫자가 다르면
                cache[n] += repeatNum.ToString() + curChar.ToString();
                curChar = nextChar;
                repeatNum = 1;
            }
            else
            { //숫자가 같으면
                repeatNum++;
            }
            strIndex++;
        }
        //마지막 0 번째 처리
        cache[n] += repeatNum.ToString() + curChar.ToString();
        System.Console.WriteLine();

        return;
    }



}