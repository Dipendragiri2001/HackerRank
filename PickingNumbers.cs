using System;
using System.Collections.Generic;
using System.Linq;

namespace Hacker_Rank
{
    public class PickingNumbers
    {
        public int pickingNumber(List<int> a)
         {
        int max = 0;
        for(int i=0;i<(a.Count());i++)
        {
            int temp = 0;
            a.Sort();
            for(int j=i;j<(a.Count);j++)
            {
                if(Math.Abs(a[i] - a[j])<=1) temp++;
                else break;
            
            }
            if(temp>max)
            {
                max = temp;
            }

        }
        return max;

    }
    }
}