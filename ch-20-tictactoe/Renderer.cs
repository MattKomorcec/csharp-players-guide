using System;
using System.Collections.Generic;
using System.Text;

namespace ch_20_tictactoe
{
    class Renderer
    {
        /// <summary>
        /// This method prints the board state to the console.
        /// </summary>
        /// <param name="board"></param>
        public void RenderBoard(State[,] board)
        {
            Console.WriteLine();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (j > 0) Console.Write($" | {SymbolForState(board[i, j])}");
                    else Console.Write($" {SymbolForState(board[i, j])}");
                }
                if (i < board.GetLength(0) - 1) Console.WriteLine("\n-----------");
                else Console.WriteLine();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// This method serves as a helper to translate board state to a character.
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        private char SymbolForState(State state)
        {
            switch (state)
            {
                case State.X:
                    return 'X';
                case State.O:
                    return 'O';
                default:
                    return ' ';
            }
        }
    }
}
