using System;
using System.Linq;

namespace Hacker_Rank
{
    public class findDigits
    {
        public static int findDigit(int n)
        {
            int input = n;
            int count = 0;
            var digits = input.ToString().Select(x => int.Parse(x.ToString()));

            foreach (var d in digits)
            {
                if (d != 0 && input % d == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}