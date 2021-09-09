using System;
using System.Collections.Generic;
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] temp;
        if (nums1.Length < nums2.Length)
        {
            temp = nums1;
            nums1 = nums2;
            nums2 = temp;
        }

        int m = nums1.Length;
        int n = nums2.Length;

        int i=0;


        //while()

    }
}