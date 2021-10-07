using System;
using System.Collections.Generic;

namespace Hacker_Rank
{
    public class HourGlassSum
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            int? maxvalue = null;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int val = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    Console.WriteLine(val);
                    if (maxvalue == null)
                    {
                        maxvalue = val;
                    }
                    else if (val > maxvalue)
                    {
                        maxvalue = val;
                    }
                }
            }
            return (int)maxvalue;
        }
    }
}