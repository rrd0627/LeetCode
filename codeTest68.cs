using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        List<string> ret = new List<string>();

        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            //첫번째가 아니면 공백을 붙여야함
            if (stringBuilder.Length != 0)
            {
                stringBuilder.Append(" ");
            }

            //지금까지 단어와 현재단어를 붙이는것이 max를 넘어가는지            
            //넘을 경우
            if (stringBuilder.Length + words[i].Length > maxWidth)
            {
                //공백 늘려주기
                SetEmptyInString(stringBuilder, maxWidth);

                //리턴에 넣어주기
                ret.Add(stringBuilder.ToString());
                stringBuilder.Clear();

                //다시 해당 word로 해야함
                i--;
            }
            //안넘으면
            else
            {
                //단어 붙임            
                stringBuilder.Append(words[i]);

                //마지막인경우
                if (i == words.Length - 1)
                {
                    //공백 넣어주기
                    int emptyCharLength = maxWidth - stringBuilder.Length;
                    for (int j = 0; j < emptyCharLength; j++)
                        stringBuilder.Append(' ');
                    //리턴에 넣어주기
                    ret.Add(stringBuilder.ToString());
                }
            }
        }
        return ret;
    }

    private void SetEmptyInString(StringBuilder stringBuilder, int maxWidth)
    {
        //마지막 공백빼고
        stringBuilder.Remove(stringBuilder.Length - 1, 1);

        int curIndex = 0;
        bool isAWord = true;
        while (stringBuilder.Length < maxWidth)
        {
            //문자에 도착                        
            while (stringBuilder.ToString()[curIndex] != ' ')
            {
                curIndex++;
                //끝까지가면 다시 0 부터
                if (curIndex == stringBuilder.Length)
                {
                    if (isAWord)
                    {
                        //공백 넣어주기
                        int emptyCharLength = maxWidth - stringBuilder.Length;
                        for (int j = 0; j < emptyCharLength; j++)
                            stringBuilder.Append(' ');
                        return;
                    }
                    curIndex = 0;
                }
            }
            //curIndex는 빈공간
            stringBuilder.Insert(curIndex, " ");

            //한단어가 아님!
            isAWord = false;

            //다음 문자로 가기
            while (curIndex < stringBuilder.Length && stringBuilder.ToString()[curIndex] == ' ')
            {
                curIndex++;
            }
        }
    }
}