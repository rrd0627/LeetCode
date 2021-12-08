using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] ret = new int[n][];
        for (int i = 0; i < n; i++)
        {
            ret[i] = new int[n];
        }

        int upBound = 0;
        int rightBound = n - 1;
        int downBound = n - 1;
        int leftBound = 0;

        int[] dirX = new int[] { 1, 0, -1, 0 }; //오 아래 좌 위
        int[] dirY = new int[] { 0, 1, 0, -1 };

        int curDir = 0;
        int curX = 0;
        int curY = 0;

        int nextX = curX + dirX[curDir];
        int nextY = curY + dirY[curDir];

        int num = 1;

        while (true)
        {
            //끝난경우
            if (num > n * n)
                break;

            //넣어주기
            ret[curY][curX] = num++;

            //다음것
            nextX = curX + dirX[curDir];
            nextY = curY + dirY[curDir];

            //다음거 가도 괜찮은지
            if (nextX <= rightBound && nextX >= leftBound && nextY <= downBound && nextY >= upBound)
            {//괜찮음
                curX = nextX;
                curY = nextY;
                continue;
            }
            else
            {//안괜찮음 

                //방향 바꿔주기
                curDir = (curDir + 1) % 4;

                //바운드 줄여주기
                switch (curDir)
                {
                    case 0://이제 오른쪽
                        leftBound++;
                        break;
                    case 1://이제 아래
                        upBound++;
                        break;
                    case 2://이제 왼쪽
                        rightBound--;
                        break;
                    case 3://이제 위
                        downBound--;
                        break;
                }

                //다음것
                curX = curX + dirX[curDir];
                curY = curY + dirY[curDir];
            }
        }
        return ret;
    }
}
