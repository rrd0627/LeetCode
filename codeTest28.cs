using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Solution {
    public int StrStr(string haystack, string needle) {
        
        if(!haystack.Contains(needle))
        {
            Console.WriteLine("no!");
            return -1;
        }

        int needleLen = needle.Length;

        for(int i=0;i<haystack.Length - needleLen + 1;i++)
        {
            if(haystack.Substring(i,needleLen)==needle)
            {
                return i;
            }
        }

        return -1;
    }
}