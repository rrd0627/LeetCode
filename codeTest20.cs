using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> map = new Dictionary<char, char>();
        Stack<char> stack = new Stack<char>();

        map.Add(')', '(');
        map.Add('}', '{');
        map.Add(']', '[');

        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsValue(s[i]))
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.TryPop(out char postChar))
                {
                    if (map[s[i]] == postChar)
                    {
                        continue;
                    }
                    else return false;
                }
                else
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}