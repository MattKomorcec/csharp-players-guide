using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 100, 54, 324, 543, 657, 87 };

            foreach (int num in scores)
            {
                Console.WriteLine(num);
            }

            int[] scoresCopy = new int[scores.Length];

            for (int i = 0; i < scoresCopy.Length; i++)
            {
                scoresCopy[i] = scores[i];
            }

            foreach (int num in scoresCopy)
            {
                Console.WriteLine(num);
            }
        }
    }
}
