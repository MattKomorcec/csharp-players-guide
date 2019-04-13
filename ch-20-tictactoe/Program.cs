using System;

namespace ch_20_tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Board board = new Board();

            string pos;

            do
            {
                board.PrintBoard();
                Console.Write("Select a place to put your sign(1-9): ");
                pos = Console.ReadLine();
                if (board.PlaceSign(pos) == "This cell is full!")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You can't place your sign on a full cell!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (board.DidSomebodyWin() != true);

            board.PrintBoard();
            Console.WriteLine(board.Winner());
        }
    }
}
