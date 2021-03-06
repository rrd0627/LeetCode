using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    List<IList<string>> ret = new List<IList<string>>();
    string _s;
    bool[,] dp;
    public IList<IList<string>> Partition(string s)
    {
        _s = s;
        dp = new bool[s.Length, s.Length];

        dfs(0, new List<string>());

        return ret;
    }

    void dfs(int start, List<string> retTemp)
    {
        if (start >= _s.Length)
        {
            ret.Add(new List<string>(retTemp));
            return;
        }

        for (int end = start; end < _s.Length; end++)
        {

            //중간이 팰린드롬이면서 끝쪽이 같으면
            if ((_s[start] == _s[end]) && (end - start <= 2 || dp[start + 1, end - 1]))
            {
                dp[start, end] = true;
                //retTemp를 넣어주고
                retTemp.Add(_s.Substring(start, end - start + 1));
                //다음것 돌려주고
                dfs(end + 1, retTemp);
                //원래자리로 돌아오기
                retTemp.RemoveAt(retTemp.Count - 1);
            }

        }
    }
}