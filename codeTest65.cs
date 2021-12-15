using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public bool IsNumber(string s)
    {
        int eIndex = int.MinValue;
        int dotIndex = int.MinValue;
        int lastNumIndex = int.MinValue;
        bool isDotok = false;
        for (int i = 0; i < s.Length; i++)
        {
            char curChar = s[i];

            if (int.TryParse(s.Substring(i, 1), out int curInt))
            {
                if (i > dotIndex)
                {
                    isDotok = true;
                }
                lastNumIndex = i;
                continue;
            }

            if (curChar == '-' || curChar == '+')
            {
                //- +
                //마지막은 안됨
                if (i == s.Length - 1)
                    return false;

                //가장 처음과 e 바로 뒤에 나올수 있음
                if (i == 0 || i == eIndex + 1)
                {
                    continue;
                }
                return false;
            }

            if (curChar == '.')
            {
                //.
                //두번 들어오면 안됨
                if (dotIndex != int.MinValue)
                    return false;
                //e 다음이면 안됨
                if (eIndex != int.MinValue && i > eIndex)
                    return false;
                
                //앞이나 뒤에 숫자가 있어야함
                if (lastNumIndex != int.MinValue)
                {
                    isDotok = true;
                }
                dotIndex = i;
                continue;
            }

            if (curChar == 'e' || curChar == 'E')
            {
                //e
                //두번 들어오면 안됨
                if (eIndex != int.MinValue)
                    return false;

                //마지막이면 안됨
                if (i == s.Length - 1)
                    return false;

                //숫자나 점 뒤에 들어오는게 아니면 안됨
                if (i != lastNumIndex + 1 && i != dotIndex + 1)
                    return false;

                //dot다음에 바로 나와버리면 안됨
                if(!isDotok)
                    return false;

                eIndex = i;

                //다음은 + - 숫자여야 함
                if (int.TryParse(s.Substring(i + 1, 1), out int intTemp))
                {
                    continue;
                }
                else
                {
                    if (s[i + 1] == '+' || s[i + 1] == '-')
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            //이상한 문자면 안됨
            return false;
        }
        System.Console.WriteLine(isDotok);
        //다 통과하면 통과!
        return isDotok;
    }
}