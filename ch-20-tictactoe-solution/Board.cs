using System;

namespace ch_20_tictactoe_solution
{
    public class Board
    {
        private State[,] state;
        public State NextTurn { get; private set; }

        public Board()
        {
            state = new State[3, 3];
            NextTurn = State.X;
        }
    }
}