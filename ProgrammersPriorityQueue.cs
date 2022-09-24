using System;
using System.Collections.Generic;


public class Solution
{
    public int[] solution(string[] operations)
    {
        int[] answer = new int[2];
        List<int> sortedList = new List<int>();

        for (int i = 0; i < operations.Length; i++)
        {
            string[] str = operations[i].Split(' ');
            if (str[0] == "I")
            {
                sortedList.Add(int.Parse(str[1]));
                sortedList.Sort((x, y) => x.CompareTo(y));
            }
            else
            {
                if (sortedList.Count == 0) continue;
                if (str[1] == "1")
                {
                    sortedList.RemoveAt(sortedList.Count - 1);
                }
                else
                {
                    sortedList.RemoveAt(0);
                }
            }
        }
        if (sortedList.Count == 0)
        {
            answer[0] = 0;
            answer[1] = 0;
        }
        else
        {
            answer[0] = sortedList[sortedList.Count - 1];
            answer[1] = sortedList[0];
        }
        return answer;
    }
}