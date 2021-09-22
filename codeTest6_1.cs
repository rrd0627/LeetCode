public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;

        bool[] isVisited = new bool[s.Length];
        char[] answer = new char[s.Length];
        int charIndex = -1, charOffset = 0;
        for (int i = 0; i < s.Length; i++)
        {
            charIndex++; //다음기준으로 넘어가기
            if (charIndex * (numRows * 2 - 2) >= s.Length + (numRows * 2 - 2)) //다시 처음으로 돌아감 Offset을 벌린채로
            {
                charIndex = 0;
                charOffset++;
            }

            bool isIplus = false;
            int small = charIndex * (numRows * 2 - 2) - charOffset;
            int big = charIndex * (numRows * 2 - 2) + charOffset;
            if (small >= 0 && small < s.Length && !isVisited[small])
            {
                answer[i] = s[small];
                isVisited[small] = true;
                isIplus = true;
                i++;
            }
            if (big >= 0 && big < s.Length && !isVisited[big])
            {
                answer[i] = s[big];
                isVisited[big] = true;
                isIplus = true;
                i++;
            }
            i--;
        }
        string answerStr = new string(answer);
        return answerStr;
    }
}