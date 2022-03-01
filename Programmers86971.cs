using System;
using System.Collections.Generic;
public class Solution
{
    int[,] Wires;
    List<int>[] adjList;
    public int solution(int n, int[,] wires)
    {
        int answer = int.MaxValue;
        Wires = wires;

        adjList = new List<int>[n + 1];
        for (int i = 0; i < adjList.Length; i++)
        {
            adjList[i] = new List<int>();
        }
        for (int i = 0; i < wires.GetLength(0); i++)
        {
            adjList[wires[i, 0]].Add(wires[i, 1]);
            adjList[wires[i, 1]].Add(wires[i, 0]);
        }

        for (int i = 0; i < wires.GetLength(0); i++)
        {
            cache = new bool[n + 1, n + 1];
            int x = GetNodeInGraph(wires[i, 0], wires[i, 0], wires[i, 1]);
            cache = new bool[n + 1, n + 1];
            int y = GetNodeInGraph(wires[i, 1], wires[i, 0], wires[i, 1]);
            answer = Math.Min(answer, Math.Abs(x - y));
        }

        return answer;
    }
    private bool[,] cache;
    private int GetNodeInGraph(int root, int cutWireStartIndex, int cutWireEndIndex)
    {
        int retNum = 1;
        for (int i = 0; i < adjList[root].Count; i++)
        {
            if (cache[adjList[root][i], root] || cache[root, adjList[root][i]]) continue;
            if (root == cutWireStartIndex && adjList[root][i] == cutWireEndIndex) continue;
            if (root == cutWireEndIndex && adjList[root][i] == cutWireStartIndex) continue;
            cache[adjList[root][i], root] = true;
            cache[root, adjList[root][i]] = true;
            retNum += GetNodeInGraph(adjList[root][i], cutWireStartIndex, cutWireEndIndex);
        }
        return retNum;
    }
}