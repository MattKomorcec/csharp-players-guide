using System;

namespace ch_20_tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Board board = new Board();
            Renderer renderer = new Renderer();
            ConsoleColor initialColor = Console.ForegroundColor;

            string pos;

            do
            {
                renderer.RenderBoard(board.boardState);
                Console.Write("Select a place to put your sign(1-9): ");
                pos = Console.ReadLine();
                if (board.PlaceSign(pos) == "This cell is full!")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You can't place your sign on a full cell!");
                    Console.ForegroundColor = initialColor;
                }

            } while (board.DidSomebodyWin() != true);

            renderer.RenderBoard(board.boardState);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(board.Winner());
            Console.ForegroundColor = initialColor;
            Console.ReadKey();
        }
    }
}
