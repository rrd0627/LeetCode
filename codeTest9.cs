using System;
using System.Collections.Generic;
public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)return false;

        string str = x.ToString();

        for(int i=0;i<str.Length/2;i++)
        {
            if(str[i]==str[str.Length-1-i])
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}