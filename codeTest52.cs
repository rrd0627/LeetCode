using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    int arraySize;
    public int TotalNQueens(int n)
    {
        arraySize = n;
        int[,] diagonalLine = new int[arraySize, arraySize];
        return dfs(0, 0, diagonalLine);
    }

    private int dfs(int horizontalLine, int verticalLine, int[,] diagonalLine)
    {
        if (horizontalLine >= arraySize)
        {
            return 1;
        }
        int retSum = 0;
        for (int i = 0; i < arraySize; i++)
        {
            if ((verticalLine & 1 << i) != 0) continue; //세로 없애기
            if (diagonalLine[horizontalLine, i] != 0) continue; //대각선 없애기

            int[,] newArr = (int[,])diagonalLine.Clone();
            for (int j = horizontalLine + 1; j < arraySize; j++)
            {
                if (i + j - horizontalLine < arraySize)
                    newArr[j, i + j - horizontalLine] = 1;
                if (i - j + horizontalLine >= 0)
                    newArr[j, i - j + horizontalLine] = 1;
            }
            retSum += dfs(horizontalLine + 1, verticalLine | 1 << i, newArr);
        }
        return retSum;
    }
}

