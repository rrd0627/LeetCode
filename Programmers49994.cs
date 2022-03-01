using System;

public class Solution
{
    bool[,,,] cache = new bool[11, 11, 11, 11];
    public int solution(string dirs)
    {
        int answer = 0;

        int curPosX = 0;
        int curPosY = 0;

        for (int i = 0; i < dirs.Length; i++)
        {
            switch (dirs[i])
            {
                case 'U':
                    if (!CheckValid(curPosX, curPosY, 0)) continue;
                    if (!IsVisited(curPosX, curPosY, curPosX, curPosY + 1)) answer++;
                    curPosY++;
                    break;
                case 'R':
                    if (!CheckValid(curPosX, curPosY, 1)) continue;
                    if (!IsVisited(curPosX, curPosY, curPosX + 1, curPosY)) answer++;
                    curPosX++;
                    break;
                case 'D':
                    if (!CheckValid(curPosX, curPosY, 2)) continue;
                    if (!IsVisited(curPosX, curPosY, curPosX, curPosY - 1)) answer++;
                    curPosY--;
                    break;
                case 'L':
                    if (!CheckValid(curPosX, curPosY, 3)) continue;
                    if (!IsVisited(curPosX, curPosY, curPosX - 1, curPosY)) answer++;
                    curPosX--;
                    break;
            }
        }
        return answer;
    }
    private bool CheckValid(int x, int y, int dir)
    {
        if (dir == 0 && y == 5) return false;
        if (dir == 1 && x == 5) return false;
        if (dir == 2 && y == -5) return false;
        if (dir == 3 && x == -5) return false;

        return true;
    }

    private bool IsVisited(int x, int y, int nextx, int nexty)
    {
        x += 5;
        y += 5;
        nextx += 5;
        nexty += 5;
        if (cache[x, y, nextx, nexty]) return true;
        cache[x, y, nextx, nexty] = true;
        cache[nextx, nexty, x, y] = true;
        return false;
    }

}