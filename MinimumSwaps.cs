using System.Linq;

namespace MinimumSwaps
{
    public class MinimumSwaps
    {
        public static int Swap(int[] arr)
        {
            int count = 0;
            for(int i = 1; i<arr.Length;i++)
            {
                while(arr[i-1]!=i)
                {
                    var index = arr.ToList().IndexOf(i);
                    int temp = arr[i-1];
                    arr[i-1] = arr[index];
                    arr[index] = temp;
                    count++;
                }
            }
            return count;
        }
    }
}