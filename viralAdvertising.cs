namespace Hacker_Rank
{
    public class viralAdvertising
    {
        public static int Advertise(int n)
        {
            var value = n;
            var liked = 0;
            for (int i = 1; i <= n; i++)
            {
                value = value / 2;

                liked += value;
                value = value * 3;

            }
            return liked;
        }
    }
}