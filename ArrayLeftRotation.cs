using System;
using System.Collections.Generic;
using System.Linq;

namespace Hacker_Rank
{
    public class ArrayLeftRotation
    {
        public static List<int> rotLeft(List<int> a, int d)
        {
            List<int> b = new List<int>(a);

            for (int i = 0; i < d; i++)
            {
                b.Add(a[i]);
                b.RemoveAt(0);

            }
            return b;
        }

    }
}