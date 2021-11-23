using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        int matrixLength = matrix.Length;
        int oldTemp = 0, nextTemp = 0, posTemp = 0;

        for (int i = 0; i < matrixLength; i++)
        {
            for (int j = i; j < matrixLength - i - 1; j++)
            {
                int posy = i;
                int posx = j;
                for (int k = 0; k < 5; k++)
                {
                    oldTemp = nextTemp;
                    nextTemp = matrix[posy][posx];
                    matrix[posy][posx] = oldTemp;

                    posTemp = posy;
                    posy = posx;
                    posx = matrix.Length - posTemp - 1;
                }
            }
        }
    }
}