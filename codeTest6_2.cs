public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows == 1 || numRows >= s.Length)
            return s;
        bool direction = false;
        string rtnValue = "";
        string [] rows = new string[numRows];
        int row = 0;
        for(var i = 0; i < s.Length; i++)
        {
            rows[row] += s[i]; //가로로 옮기며 세로로 쌓음
            if(!direction) //대각선이 아닌경우
            {
                row++; //오른쪽으로 가고
            }
            else 
            {
                row--; //왼쪽으로 감
            }
            
            if(row == 0 || row == (numRows - 1)) //왼쪽끝까지 온경우 or 오른쪽끝에 닿은경우
                direction = !direction; //방향 바꾸기
        }
        
        for(var i = 0; i < numRows; i++) //세로로 쌓아논 아이대로 넣기
        {
            rtnValue += rows[i];
        }
        return rtnValue;
        
    }
}