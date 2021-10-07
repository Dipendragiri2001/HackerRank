using System;
using System.Linq;

namespace Hacker_Rank
{
    public static class BeautifulDays
    {
    public static int Reverse(int number) {
         return int.Parse(number.ToString().Reverse().Aggregate("", (s,c) => s+c));
    }
    public static int beautifulDays(int i, int j, int k)
    { 
        int count = 0;
        for(int d=i;d<j+1;d++)
        {
            var r = Reverse(d);
            var sub = d-r;
            if(sub%k==0)
            {
                count++;
            }
            
        }
        Console.WriteLine(count);
        return count;
    }
    }
}