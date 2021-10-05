using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    Dictionary<char, string> numberToChar;
    List<string> ret;

    public IList<string> LetterCombinations(string digits)
    {
        ret = new List<string>();
        if (digits.Length == 0) return ret;

        numberToChar = new Dictionary<char, string>();
        numberToChar.Add('2', "abc");
        numberToChar.Add('3', "def");
        numberToChar.Add('4', "ghi");
        numberToChar.Add('5', "jkl");
        numberToChar.Add('6', "mno");
        numberToChar.Add('7', "pqrs");
        numberToChar.Add('8', "tuv");
        numberToChar.Add('9', "wxyz");

        DFS(digits, "", 0);

        return ret;
    }

    public void DFS(string digits, string curString, int index)
    {
        string str = numberToChar[digits[index]];

        if (index >= digits.Length - 1)
        {
            for (int i = 0; i < str.Length; i++)
            {
                ret.Add(curString + str[i]);
            }
            return;
        }
        for (int i = 0; i < str.Length; i++)
        {
            DFS(digits, curString + str[i], index + 1);
        }
    }
}