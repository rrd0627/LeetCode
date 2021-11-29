using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace codetest54
{
    public class Solution
    {
        static readonly int[] dirX = { 0, 1, 0, -1 };
        static readonly int[] dirY = { -1, 0, 1, 0 };

        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> ret = new List<int>();

            int matrixYSize = matrix.Length;
            int matrixXSize = matrix[0].Length;

            int curX = 0;
            int curY = 0;
            int curDir = 1; //오른쪽
            int nextX = 0;
            int nextY = 0;

            while (true)
            {
                //처음온곳이이니까 ADD
                ret.Add(matrix[curY][curX]);
                //매트릭스 초기화시켜버리기!
                matrix[curY][curX] = int.MinValue;

                //다음갈곳
                nextX = curX + dirX[curDir];
                nextY = curY + dirY[curDir];

                //다음 갈곳 괜찬은지 //배열을 넘어가거나 이미 왔던곳이거나
                if (nextX >= matrixXSize || nextX < 0 || nextY >= matrixYSize || nextY < 0 || matrix[nextY][nextX] == int.MinValue)
                {
                    //안괜찮음 
                    //방향바꾸기
                    curDir = (curDir + 1) % 4;

                    //다음갈곳
                    nextX = curX + dirX[curDir];
                    nextY = curY + dirY[curDir];

                    //방향 바꾸었는데도 또?!
                    if (nextX >= matrixXSize || nextX < 0 || nextY >= matrixYSize || nextY < 0 || matrix[nextY][nextX] == int.MinValue)
                    {
                        //끝
                        break;
                    }
                }

                //다음으로
                curX = nextX;
                curY = nextY;
            }
            return ret;
        }
    }
}
