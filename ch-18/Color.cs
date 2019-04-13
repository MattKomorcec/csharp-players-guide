using System;

namespace ch_18
{
    class Color
    {
        private short red;
        private short green;
        private short blue;
        private short alpha;

        public int grayscale;

        public Color(short red, short green, short blue, short alpha)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = alpha;
        }

        public Color(short red, short green, short blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public short GetRed()
        {
            return red;
        }

        public void SetRed(short red)
        {
            this.red = red;
        }

        public short GetGreen()
        {
            return green;
        }

        public void SetGreen(short green)
        {
            this.green = green;
        }

        public short GetBlue()
        {
            return blue;
        }

        public void SetBlue(short blue)
        {
            this.blue = blue;
        }

        public short GetAlpha()
        {
            return alpha;
        }

        public void SetAlpha(short alpha)
        {
            this.alpha = alpha;
        }

        public void SetGrayscale()
        {
            this.grayscale = (red + blue + green) / 3;
        }
    }
}