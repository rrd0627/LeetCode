using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        //. 으로 나누기
        string[] version1Split = version1.Split('.');
        string[] version2Split = version2.Split('.');

        int min = Math.Min(version1Split.Length, version2Split.Length);

        // 나뉜거 처음부터 비교하기 0은 뺀다! 01 == 001 
        for (int i = 0; i < min; i++)
        {
            int version1Int = int.Parse(version1Split[i]);
            int version2Int = int.Parse(version2Split[i]);

            if (version1Int > version2Int)
                return 1;
            else if (version1Int < version2Int)
                return -1;
        }

        //비교한곳 까지는 다 같으면 여기까지옴 length가 더 길면 더 큰데! 0 인경우는 제외
        if (version1Split.Length > version2Split.Length)
        {
            for (int i = version2Split.Length; i < version1Split.Length; i++)
            {
                int version1Int = int.Parse(version1Split[i]);
                if (version1Int != 0) return 1;
            }
        }
        else if (version1Split.Length < version2Split.Length)
        {
            for (int i = version1Split.Length; i < version2Split.Length; i++)
            {
                int version2Int = int.Parse(version2Split[i]);
                if (version2Int != 0) return -1;
            }
        }
        //그것도 아니면 같은걸로!
        return 0;
    }
}