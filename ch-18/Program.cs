using System;

namespace ch_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to chapter 18!");

            Color color1 = new Color(14, 55, 254);
            Color color2 = new Color(255, 255, 255, 34);

            Ball ball1 = new Ball(25, color1);
            Ball ball2 = new Ball(15, color2);

            ball2.Throw();
            ball2.Throw();
            ball2.Throw();
            ball2.Throw();
            ball1.Pop();
            Console.WriteLine($"Ball2 has been thrown {ball2.TimesThrown()} times!");
            Console.WriteLine($"Ball1 has been thrown {ball1.TimesThrown()} times!");
        }
    }
}
