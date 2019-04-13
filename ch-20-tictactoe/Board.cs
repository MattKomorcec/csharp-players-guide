using System;
using System.Collections;

namespace ch_20_tictactoe
{
    class Board
    {
        private string[,] board = new string[3, 3] { {"_", "_", "_"},
                                                    {"_", "_", "_"},
                                                    {"_", "_", "_"} };

        private string currentPlayer = "X";

        public void PrintBoard()
        {
            Console.WriteLine();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (j > 0) Console.Write($" | {board[i, j]}");
                    else Console.Write($" {board[i, j]}");
                }
                if (i < board.GetLength(0) - 1) Console.WriteLine("\n-----------");
                else Console.WriteLine();
            }

            Console.WriteLine();
        }

        public bool DidSomebodyWin()
        {
            return DidPlayerOWin() || DidPlayerXWin() || DidGameEndInDraw();
        }

        private bool DidPlayerXWin()
        {
            return (board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X") ||
                (board[1, 0] == "X" && board[1, 1] == "X" && board[1, 2] == "X") ||
                (board[2, 0] == "X" && board[2, 1] == "X" && board[2, 2] == "X") ||
                (board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X") ||
                (board[0, 2] == "X" && board[1, 1] == "X" && board[2, 0] == "X") ||
                (board[0, 0] == "X" && board[1, 0] == "X" && board[2, 0] == "X") ||
                (board[0, 1] == "X" && board[1, 1] == "X" && board[2, 1] == "X") ||
                (board[0, 2] == "X" && board[1, 2] == "X" && board[2, 2] == "X");
        }

        private bool DidPlayerOWin()
        {
            return (board[0, 0] == "O" && board[0, 1] == "O" && board[0, 2] == "O") ||
                (board[1, 0] == "O" && board[1, 1] == "O" && board[1, 2] == "O") ||
                (board[2, 0] == "O" && board[2, 1] == "O" && board[2, 2] == "O") ||
                (board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O") ||
                (board[0, 2] == "O" && board[1, 1] == "O" && board[2, 0] == "O") ||
                (board[0, 0] == "O" && board[1, 0] == "O" && board[2, 0] == "O") ||
                (board[0, 1] == "O" && board[1, 1] == "O" && board[2, 1] == "O") ||
                (board[0, 2] == "O" && board[1, 2] == "O" && board[2, 2] == "O");
        }

        private bool DidGameEndInDraw()
        {
            return (board[0, 0] != "_" && board[0, 1] != "_" && board[0, 2] != "_") &&
                (board[1, 0] != "_" && board[1, 1] != "_" && board[1, 2] != "_") &&
                (board[2, 0] != "_" && board[2, 1] != "_" && board[2, 2] != "_");
        }

        public string PlaceSign(string pos)
        {
            string message = "Placing a sign...";

            switch (pos)
            {
                case "1":
                    if (board[0, 0] != "_")
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        board[0, 0] = currentPlayer;
                    }
                    break;
                case "2":
                    if (board[0, 1] != "_")
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        board[0, 1] = currentPlayer;
                    }
                    break;
                case "3":
                    if (board[0, 2] != "_")
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        board[0, 2] = currentPlayer;
                    }
                    break;
                case "4":
                    if (board[1, 0] != "_")
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        board[1, 0] = currentPlayer;
                    }
                    break;
                case "5":
                    if (board[1, 1] != "_")
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        board[1, 1] = currentPlayer;
                    }
                    break;
                case "6":
                    if (board[1, 2] != "_")
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        board[1, 2] = currentPlayer;
                    }
                    break;
                case "7":
                    if (board[2, 0] != "_")
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        board[2, 0] = currentPlayer;
                    }
                    break;
                case "8":
                    if (board[2, 1] != "_")
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        board[2, 1] = currentPlayer;
                    }
                    break;
                case "9":
                    if (board[2, 2] != "_")
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        board[2, 2] = currentPlayer;
                    }
                    break;
            }
            if (message != "This cell is full!")
            {
                currentPlayer = currentPlayer == "X" ? "O" : "X";
            }
            return message;
        }

        public string Winner()
        {
            if (DidPlayerOWin())
            {
                return "Player O won the game!";
            }
            else if (DidPlayerXWin())
            {
                return "Player X won the game!";
            }
            else
            {
                return "The game ended in a draw!";
            }
        }
    }
}