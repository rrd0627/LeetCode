using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<int>[] row = new HashSet<int>[9];
        HashSet<int>[] column = new HashSet<int>[9];
        HashSet<int>[] box = new HashSet<int>[9];

        for (int i = 0; i < 9; i++)
        {
            row[i] = new HashSet<int>();
            column[i] = new HashSet<int>();
            box[i] = new HashSet<int>();
        }


        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (int.TryParse(board[i][j].ToString(), out int result))
                {
                    row[i].Add(result);
                    column[j].Add(result);
                    box[(i / 3) * 3 + j / 3].Add(result);
                }
            }
        }

        while (true)
        {
            for (int num = 0; num < 9; num++)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                    }
                }
            }
        }

    }



}