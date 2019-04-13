using System;

namespace ch_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to chapter 19!");

            Color color1 = new Color(14, 55, 254);
            Color color2 = new Color(255, 255, 255, 34);

            Ball ball1 = new Ball() { Size = 25, Color = color1 };
            Ball ball2 = new Ball() { Size = 15, Color = color2 };

            ball2.Throw();
            ball2.Throw();
            ball2.Throw();
            ball2.Throw();
            ball1.Pop();
            Console.WriteLine($"Ball2 has been thrown {ball2.TimesThrownCount} times!");
            Console.WriteLine($"Ball1 has been thrown {ball1.TimesThrownCount} times!");
        }
    }
}
