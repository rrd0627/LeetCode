using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int Calculate(string s)
    {
        s += '+';
        Stack<int> stack = new Stack<int>();
        StringBuilder curNumStr = new StringBuilder();
        int oldNum;
        char oldOperator = '+';
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/')
            {
                int.TryParse(curNumStr.ToString(), out oldNum);
                curNumStr.Clear();
                if (oldOperator == '+') stack.Push(oldNum);
                else if (oldOperator == '-') stack.Push(-oldNum);
                else if (oldOperator == '*') stack.Push(stack.Pop() * oldNum);
                else if (oldOperator == '/') stack.Push(stack.Pop() / oldNum);
                oldOperator = s[i];
                continue;
            }
            if (s[i] == ' ')
            {
                continue;
            }
            curNumStr.Append(s[i]);
        }
        return stack.Sum();
    }
}