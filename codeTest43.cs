using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution
{
    public string Multiply(string num1, string num2)
    {
        Dictionary<char, int> charToInt = new Dictionary<char, int>(){
            {'0',0},{'1',1},{'2',2},{'3',3},{'4',4},{'5',5},{'6',6},{'7',7},{'8',8},{'9',9}
        };
        if(num1.Equals("0")||num2.Equals("0"))return "0";

        int[] result = new int[num1.Length + num2.Length];

        int numi, numj;

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            numi = charToInt[num1[i]];
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                numj = charToInt[num2[j]];

                result[i + j] += numi * numj;

                if (result[i + j] >= 10 && i + j != 0)
                {
                    result[i + j - 1] += result[i + j] / 10;
                    result[i + j] = result[i + j] % 10;
                }
            }
        }

        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < num1.Length + num2.Length - 1; i++)
        {
            stringBuilder.Append(result[i]);
        }

        return stringBuilder.ToString();
    }
}