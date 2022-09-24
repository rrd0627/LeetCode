using System;
using System.Collections.Generic;
public class Solution
{
    public int[] solution(string[] enroll, string[] referral, string[] seller, int[] amount)
    {
        int[] answer = new int[enroll.Length];

        Dictionary<string, int> nameToIndex = new Dictionary<string, int>();

        for (int i = 0; i < enroll.Length; i++)
        {
            nameToIndex.Add(enroll[i], i);
        }

        int currentMoney;
        string currentPerson;
        //한개 팔때마다 위로 올려주기
        for (int i = 0; i < seller.Length; i++)
        {
            currentMoney = amount[i] * 100;
            currentPerson = seller[i];

            //맨위까지 올라가거나 10프로가 1원미만이면 끝
            while (true)
            {
                //10프로가 1원 미만
                if (currentMoney / 10 == 0)
                {
                    answer[nameToIndex[currentPerson]] += currentMoney;
                    break;
                }
                answer[nameToIndex[currentPerson]] += currentMoney - currentMoney / 10;


                currentPerson = referral[nameToIndex[currentPerson]];
                currentMoney = currentMoney / 10;

                if (currentPerson == "-") break;
            }
        }
        return answer;
    }
}