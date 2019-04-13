using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 15;

            for (int row = 1; row < height * 2; row += 2)
            {
                for (int empty = 0; empty < ((height * 2) - row) / 2; empty++)
                {
                    Console.Write(" ");
                }
                for (int sign = 0; sign < row; sign++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
