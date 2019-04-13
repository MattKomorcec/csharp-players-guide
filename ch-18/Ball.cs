using System;

namespace ch_18
{
    class Ball
    {
        private int size;
        private Color color;
        private int timesThrown;

        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if (size > 0)
            {
                timesThrown += 1;
            }
            else
            {
                Console.WriteLine("Ball cannot be thrown as the size is 0!");
            }
        }

        public int TimesThrown()
        {
            return timesThrown;
        }
    }
}