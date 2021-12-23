using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        Queue<int> orderQue = new Queue<int>();
        List<List<int>> linkList = new List<List<int>>();
        for (int i = 0; i < numCourses; i++)
        {
            List<int> tempList = new List<int>();
            linkList.Add(tempList);
        }
        List<int> ret = new List<int>();

        for (int i = 0; i < prerequisites.Length; i++)
        {
            linkList[prerequisites[i][0]].Add(prerequisites[i][1]);
        }

        // 1 들어오는게 없는 아이를 q에 넣음
        for (int i = numCourses - 1; i >= 0; i--)
        {
            if (linkList[i].Count == 0)
            {
                orderQue.Enqueue(i);
            }
        }

        // 2 q에서 꺼냄
        while (orderQue.Count > 0)
        {
            int curNum = orderQue.Dequeue();
            ret.Add(curNum);

            //3 해당 Num 에서 들어가는 아이 없애고 q에 넣음
            for (int i = 0; i < numCourses; i++)
            {
                if (ret.Contains(i)) continue;

                //들어가는 아이가 있으면 빼주기
                if (linkList[i].Contains(curNum))
                {
                    linkList[i].Remove(curNum);
                    if (linkList[i].Count == 0)
                    {
                        System.Console.WriteLine(i);
                        orderQue.Enqueue(i);
                    }
                }
            }
        }

        if (ret.Count == numCourses)
            return ret.ToArray();
        else
        {
            return new int[0];
        }
    }
}