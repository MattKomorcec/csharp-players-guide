using System;

namespace ch_19
{
    class Color
    {
        public short Red { get; set; }
        private short green;
        private short blue;
        private short alpha;

        public int grayscale;

        public Color(short red, short green, short blue, short alpha)
        {
            Red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = alpha;
        }

        public Color(short red, short green, short blue)
        {
            Red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
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
            this.grayscale = (Red + blue + green) / 3;
        }
    }
}