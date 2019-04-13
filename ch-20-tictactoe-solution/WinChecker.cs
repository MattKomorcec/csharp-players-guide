using System;
using System.Collections.Generic;
using System.Text;

namespace ch_20_tictactoe_solution
{
    class WinChecker
    {
        public State Check(Board board)
        {
            if (CheckForWin(board, State.X)) return State.X;
            if (CheckForWin(board, State.O)) return State.O;
            return State.Empty;
        }

        private bool CheckForWin(Board board, State player)
        {
            for (int row = 0; row < 3; row++)
            {
                if (AreAll(board, new Position[] { new Position(row, 0), new Position(row, 1), new Position(row, 2) }, player))
                    return true;
            }

            for (int column = 0; column < 3; column++)
            {
                if (AreAll(board, new Position[] { new Position(0, column), new Position(1, column), new Position(2, column) }, player ))
                    return true;
            }

            return false;
        }

        private bool AreAll(Board board, Position[] positions, State state)
        {
            foreach(Position position in positions)
            {
                if (board.GetState(position) != state) return false;
            }
            return true;
        }

        public bool IsDraw(Board board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (board.GetState(new Position(row, column)) == State.Empty) return false;
                }
            }
            return true;
        }
    }
}
