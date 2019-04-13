using System;

namespace ch_19
{
    class Ball
    {
        public int Size { get; set; }
        public Color Color { get; set; }
        private int timesThrown;

        public int TimesThrownCount
        {
            get
            {
                return timesThrown;
            }
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                timesThrown += 1;
            }
            else
            {
                Console.WriteLine("Ball cannot be thrown as the size is 0!");
            }
        }
    }
}