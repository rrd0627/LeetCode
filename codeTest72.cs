using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        int[,] dist = new int[word1.Length + 1, word2.Length + 1];

        for (int i = 0; i < word1.Length + 1; i++)
        {
            dist[i, 0] = i;
        }
        for (int i = 0; i < word2.Length + 1; i++)
        {
            dist[0, i] = i;
        }

        for (int i = 0; i < word1.Length; i++)
        {
            for (int j = 0; j < word2.Length; j++)
            {
                if (word1[i] == word2[j])
                {
                    dist[i + 1, j + 1] = dist[i, j];
                }
                else
                {
                    dist[i + 1, j + 1] = Min(dist[i, j + 1], dist[i + 1, j], dist[i, j]) + 1;
                }

            }
        }
        return dist[word1.Length, word2.Length];
    }

    private int Min(int a, int b, int c)
    {
        return Math.Min(Math.Min(a, b), c);
    }
}