using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    HashSet<int>[] _rowHash = new HashSet<int>[9];
    HashSet<int>[] _columnHash = new HashSet<int>[9];
    HashSet<int>[] _boxHash = new HashSet<int>[9];

    char[] DIGIT = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    Dictionary<char, int> _charToInt = new Dictionary<char, int>();
    public void SolveSudoku(char[][] board)
    {
        for (int i = 0; i < 9; i++)
        {
            _rowHash[i] = new HashSet<int>();
            _columnHash[i] = new HashSet<int>();
            _boxHash[i] = new HashSet<int>();
            _charToInt.Add(DIGIT[i], i + 1);
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] != '.')
                {
                    _rowHash[i].Add(_charToInt[board[i][j]]);
                    _columnHash[j].Add(_charToInt[board[i][j]]);
                    _boxHash[(i / 3) * 3 + j / 3].Add(_charToInt[board[i][j]]);
                }
            }
        }
        Sudoku(0, 0, ref board);

        return;
    }

    private bool Sudoku(int vertical, int horizontal, ref char[][] board)
    {
        if (vertical >= 9)
        {
            return true;
        }
        if (horizontal >= 9)
        {
            return Sudoku(vertical + 1, 0, ref board);
        }

        if (board[vertical][horizontal] != '.')
        {
            //이미 숫자가 들어가있으면 다음으로 넘김
            return Sudoku(vertical, horizontal + 1, ref board);
        }

        for (int i = 0; i < 9; i++)
        {
            if (CanInput(vertical, horizontal, i + 1, ref board))
            {
                //넣을 수 있음! 넣기!
                board[vertical][horizontal] = DIGIT[i];

                if (Sudoku(vertical, horizontal + 1, ref board)) return true;

                //지금 자리는 틀렸다는소리! 다시 빼주기
                board[vertical][horizontal] = '.';

                _rowHash[vertical].Remove(i + 1);
                _columnHash[horizontal].Remove(i + 1);
                _boxHash[(vertical / 3) * 3 + horizontal / 3].Remove(i + 1);
            }
        }

        return false;
    }

    private bool CanInput(int vertical, int horizontal, int num, ref char[][] board)
    {
        if (!_rowHash[vertical].Add(num))
        {
            return false;
        }
        if (!_columnHash[horizontal].Add(num))
        {
            _rowHash[vertical].Remove(num);
            return false;
        }
        if (!_boxHash[(vertical / 3) * 3 + horizontal / 3].Add(num))
        {
            _rowHash[vertical].Remove(num);
            _columnHash[horizontal].Remove(num);
            return false;
        }
        return true;
    }

}