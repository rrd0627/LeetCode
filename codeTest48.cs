using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        int matrixLength = matrix.Length;
        int oldTemp, nextTemp;
        int[] column = new int[matrixLength];
        for (int i = 0; i < matrixLength; i++)
        {            
            for (int j = 0; j < matrixLength; j++)
            {
                column[j] = matrix[j][i];
            }
        }
        matrix = ret;
    }
}