using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int[] retArr = new int[obstacleGrid[0].Length];
        retArr[0] = 1;

        for (int i = 0; i < obstacleGrid.Length; i++)
        {
            for (int j = 0; j < obstacleGrid[0].Length; j++)
            {
                if (obstacleGrid[i][j] == 1)
                {
                    retArr[j] = 0;
                }
                else
                {
                    if (j == 0) continue;
                    retArr[j] += retArr[j - 1];
                }
            }
        }
        return retArr[retArr.Length - 1];
    }
}