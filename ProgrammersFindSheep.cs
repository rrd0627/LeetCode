using System;

public class Solution
{

    public class Node
    {
        public int sheep;
        public int wolf;
        public int parent;
        public List<int> child = new List<int>();
    }
    public int solution(int[] info, int[,] edges)
    {
        int answer = 0;

        Node[] nodeInfo = new Node[info.Length];

        for (int i = 0; i < edges.GetLength(0); i++)
        {
            //부모
            nodeInfo[edges[i, 0]].child


        }


        //양을 얻게 되면 모든 visited node의 최대 양 개수가 늘어남

        //더 이상 갈 수 없는 최전선을 캐싱 해 놓았다가 양 개수가 refresh 될때마다 꺼내 먹어요~


        //전체를 재조사해도 17개밖에 없어서 할만하다!
        return answer;
    }
}