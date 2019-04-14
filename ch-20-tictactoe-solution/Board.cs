using System;

namespace ch_20_tictactoe_solution
{
    public class Board
    {
        private readonly State[,] state;
        public State NextTurn { get; private set; }

        public Board()
        {
            state = new State[3, 3];
            NextTurn = State.X;
        }

        public State GetState(Position position)
        {
            return state[position.Row, position.Column];
        }

        public bool SetState(Position position, State newState)
        {
            if (newState != NextTurn) return false;
            if (state[position.Row, position.Column] != State.Empty) return false;

            state[position.Row, position.Column] = newState;
            SwitchNextTurn();
            return true;
        }

        private void SwitchNextTurn()
        {
            if (NextTurn == State.X) NextTurn = State.O;
            else NextTurn = State.X;
        }
    }
}