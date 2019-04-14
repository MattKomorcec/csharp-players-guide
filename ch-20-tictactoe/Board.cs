using System;
using System.Collections;

namespace ch_20_tictactoe
{
    class Board
    {
        public State[,] boardState = null;

        public Board()
        {
            boardState = new State[3, 3];
        }

        private State currentPlayer = State.X;

        /// <summary>
        /// This method checks if anyone won.
        /// </summary>
        /// <returns></returns>
        public bool DidSomebodyWin()
        {
            return DidPlayerOWin() || DidPlayerXWin() || DidGameEndInDraw();
        }

        /// <summary>
        /// This method checks if player X won.
        /// </summary>
        /// <returns></returns>
        private bool DidPlayerXWin()
        {
            return (boardState[0, 0] == State.X && boardState[0, 1] == State.X && boardState[0, 2] == State.X) ||
                (boardState[1, 0] == State.X && boardState[1, 1] == State.X && boardState[1, 2] == State.X) ||
                (boardState[2, 0] == State.X && boardState[2, 1] == State.X && boardState[2, 2] == State.X) ||
                (boardState[0, 0] == State.X && boardState[1, 1] == State.X && boardState[2, 2] == State.X) ||
                (boardState[0, 2] == State.X && boardState[1, 1] == State.X && boardState[2, 0] == State.X) ||
                (boardState[0, 0] == State.X && boardState[1, 0] == State.X && boardState[2, 0] == State.X) ||
                (boardState[0, 1] == State.X && boardState[1, 1] == State.X && boardState[2, 1] == State.X) ||
                (boardState[0, 2] == State.X && boardState[1, 2] == State.X && boardState[2, 2] == State.X);
        }

        /// <summary>
        /// This method checks if player O won.
        /// </summary>
        /// <returns></returns>
        private bool DidPlayerOWin()
        {
            return (boardState[0, 0] == State.O && boardState[0, 1] == State.O && boardState[0, 2] == State.O) ||
                (boardState[1, 0] == State.O && boardState[1, 1] == State.O && boardState[1, 2] == State.O) ||
                (boardState[2, 0] == State.O && boardState[2, 1] == State.O && boardState[2, 2] == State.O) ||
                (boardState[0, 0] == State.O && boardState[1, 1] == State.O && boardState[2, 2] == State.O) ||
                (boardState[0, 2] == State.O && boardState[1, 1] == State.O && boardState[2, 0] == State.O) ||
                (boardState[0, 0] == State.O && boardState[1, 0] == State.O && boardState[2, 0] == State.O) ||
                (boardState[0, 1] == State.O && boardState[1, 1] == State.O && boardState[2, 1] == State.O) ||
                (boardState[0, 2] == State.O && boardState[1, 2] == State.O && boardState[2, 2] == State.O);
        }

        /// <summary>
        /// This method checks if game ended in a draw.
        /// </summary>
        /// <returns></returns>
        private bool DidGameEndInDraw()
        {
            return (boardState[0, 0] != State.Empty && boardState[0, 1] != State.Empty && boardState[0, 2] != State.Empty) &&
                (boardState[1, 0] != State.Empty && boardState[1, 1] != State.Empty && boardState[1, 2] != State.Empty) &&
                (boardState[2, 0] != State.Empty && boardState[2, 1] != State.Empty && boardState[2, 2] != State.Empty);
        }

        /// <summary>
        /// This method attempts to place a sign on the board.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public string PlaceSign(string pos)
        {
            string message = "Placing a sign...";

            switch (pos)
            {
                case "1":
                    if (boardState[0, 0] != State.Empty)
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        boardState[0, 0] = currentPlayer;
                    }
                    break;
                case "2":
                    if (boardState[0, 1] != State.Empty)
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        boardState[0, 1] = currentPlayer;
                    }
                    break;
                case "3":
                    if (boardState[0, 2] != State.Empty)
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        boardState[0, 2] = currentPlayer;
                    }
                    break;
                case "4":
                    if (boardState[1, 0] != State.Empty)
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        boardState[1, 0] = currentPlayer;
                    }
                    break;
                case "5":
                    if (boardState[1, 1] != State.Empty)
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        boardState[1, 1] = currentPlayer;
                    }
                    break;
                case "6":
                    if (boardState[1, 2] != State.Empty)
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        boardState[1, 2] = currentPlayer;
                    }
                    break;
                case "7":
                    if (boardState[2, 0] != State.Empty)
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        boardState[2, 0] = currentPlayer;
                    }
                    break;
                case "8":
                    if (boardState[2, 1] != State.Empty)
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        boardState[2, 1] = currentPlayer;
                    }
                    break;
                case "9":
                    if (boardState[2, 2] != State.Empty)
                    {
                        message = "This cell is full!";
                    }
                    else
                    {
                        boardState[2, 2] = currentPlayer;
                    }
                    break;
            }
            if (message != "This cell is full!")
            {
                currentPlayer = currentPlayer == State.X ? State.O : State.X;
            }
            return message;
        }

        /// <summary>
        /// This method formats the string with the winner of the game.
        /// </summary>
        /// <returns></returns>
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