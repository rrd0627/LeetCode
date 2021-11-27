using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace codeTest51
{
    public class Solution
    {
        List<IList<string>> retStr = new List<IList<string>>();
        int arraySize;
        public IList<IList<string>> SolveNQueens(int n)
        {
            arraySize = n;
            int[,] diagonalLine = new int[arraySize, arraySize];
            dfs(new List<string>(), 0, diagonalLine);
            return retStr;
        }

        private void dfs(List<string> list, int verticalLine, int[,] diagonalLine)
        {
            int listCount = list.Count;
            if (listCount >= arraySize)
            {
                retStr.Add(list);
                return;
            }

            for (int i = 0; i < arraySize; i++)
            {
                if ((verticalLine & 1 << i) != 0) continue; //세로 없애기
                if (diagonalLine[listCount, i] != 0) continue; //대각선 없애기

                StringBuilder newStr = new StringBuilder();
                for (int j = 0; j < arraySize; j++)
                {
                    if (j == i)
                    {
                        newStr.Append('Q');
                        continue;
                    }
                    newStr.Append('.');
                }

                List<string> newList = new List<string>(list);
                newList.Add(newStr.ToString());
                int[,] newArr = (int[,])diagonalLine.Clone();
                for (int j = listCount + 1; j < arraySize; j++)
                {
                    if (i + j - listCount < arraySize)
                        newArr[j, i + j - listCount] = 1;
                    if (i - j + listCount >= 0)
                        newArr[j, i - j + listCount] = 1;
                }
                dfs(newList, verticalLine | 1 << i, newArr);
            }
        }
    }
}
