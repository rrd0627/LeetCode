using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public string SimplifyPath(string path)
    {
        Stack<string> fileStack = new Stack<string>();

        path = path.Replace("//", "/");

        string[] files = path.Split('/');
        for (int i = 0; i < files.Length; i++)
        {
            if (files[i].Length == 0) continue;
            if (files[i] == ".") continue;

            if (files[i] == "..")
            {
                if (fileStack.Count != 0)
                    fileStack.Pop();
            }
            else
            {
                fileStack.Push(files[i]);
            }
        }

        StringBuilder ret = new StringBuilder();

        while (fileStack.Count != 0)
        {
            ret.Insert(0,fileStack.Pop());
            ret.Insert(0,"/");
        }
        if (ret.Length == 0) ret.Append("/");
        return ret.ToString();
    }
}