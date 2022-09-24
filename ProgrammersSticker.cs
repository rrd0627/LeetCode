    using System;
    using System.Collections.Generic;

    class Solution
    {
        //해당 장소까지 왔을때 가장 점수
        int[] maxValuefirst;
        int[] maxValuesecond;
        public int solution(int[] sticker)
        {
            if (sticker.Length <= 3)
            {
                int maxValue = 0;
                for (int i = 0; i < sticker.Length; i++)
                {
                    if (maxValue < sticker[i])
                        maxValue = sticker[i];
                }
                return maxValue;
            }

            maxValuefirst = new int[sticker.Length];
            maxValuesecond = new int[sticker.Length];

            maxValuefirst[0] = sticker[0];
            maxValuefirst[1] = sticker[1];
            maxValuefirst[2] = sticker[2] + sticker[0];

            maxValuesecond[0] = 0;
            maxValuesecond[1] = sticker[1];
            maxValuesecond[2] = sticker[2];


            
            //현재 값은 -2랑 -3꺼 중에 큰것을 현재 값과 더한것
            for (int i = 3; i < sticker.Length; i++)
            {
                maxValuefirst[i] = Math.Max(maxValuefirst[i - 2], maxValuefirst[i - 3]) + sticker[i];
                maxValuesecond[i] = Math.Max(maxValuesecond[i - 2], maxValuesecond[i - 3]) + sticker[i];
            }

            int firstMax = Math.Max(maxValuefirst[sticker.Length - 2], maxValuefirst[sticker.Length - 3]);
            int secondMax = Math.Max(maxValuesecond[sticker.Length - 1], maxValuesecond[sticker.Length - 2]);

            return Math.Max(firstMax, secondMax);
        }
    }