using System;
using System.Collections.Generic;
using System.Linq;

namespace Name
{
    public class NewYearChaos
    {
        public static void minimumBribes(List<int> q)
        {
            int totalBribes = 0;

            int expectedFirst = 1;
            int expectedSecond = 2;
            int expectedThird = 3;

            for (int i = 0; i < q.Count(); ++i)
            {
                if (q[i] == expectedFirst)
                {
                    expectedFirst = expectedSecond;
                    expectedSecond = expectedThird;
                    ++expectedThird;
                }
                else if (q[i] == expectedSecond)
                {
                    ++totalBribes;
                    expectedSecond = expectedThird;
                    ++expectedThird;
                }
                else if (q[i] == expectedThird)
                {
                    totalBribes += 2;
                    ++expectedThird;
                }
                else
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }
            Console.WriteLine(totalBribes);
        }

    }
}
