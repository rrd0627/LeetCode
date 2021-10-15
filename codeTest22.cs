using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        return GetList(n, 0, "");
    }

    public List<string> GetList(int openLeft, int curOpenStack, string curStr)
    {
        List<string> ret = new List<string>();
        if (curOpenStack == 0)
        {
            if (openLeft == 0)
            {
                //끝
                ret.Add(curStr);
            }
            else
            {
                //브라켓 열기
                ret.AddRange(GetList(openLeft - 1, curOpenStack + 1, curStr + "("));
            }
        }
        else
        {
            //닫기
            ret.AddRange(GetList(openLeft, curOpenStack - 1, curStr + ")"));

            if (openLeft > 0)
            {//열기
                ret.AddRange(GetList(openLeft - 1, curOpenStack + 1, curStr + "("));
            }
        }
        return ret;
    }
}