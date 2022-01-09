using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
    public bool IsRobotBounded(string instructions)
    {
        //위치
        int curposx = 0;
        int curposy = 0;
        int dir = 0; //위 오 아래 왼

        for (int i = 0; i < instructions.Length; i++)
        {
            if (instructions[i] == 'L') dir--;
            else if (instructions[i] == 'R') dir++;
            else if (instructions[i] == 'G')
            {
                if (dir % 4 == 0)
                    curposy++;
                if (dir % 4 == 1 || dir % 4 == -3)
                    curposx++;
                if (dir % 4 == 2 || dir % 4 == -2)
                    curposy--;
                if (dir % 4 == 3 || dir % 4 == -1)
                    curposx--;
            }
        }
        //한 사이클 돈 뒤에 위치가 원점이면 무조건 원래자리임
        if (curposx == 0 && curposy == 0) return true;
        //한 사이클 돌았는데 같은곳을 보고있으면 무조건 멀어짐
        if (dir % 4 == 0) return false;
        //그 외에는 다 돌아옴
        return true;
    }
}