using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Square : Shape
    {
        public Square(int width, int height) : base(width, height)
        {
        }
        public int Pole()
        {
            return Width * Height;
        }
        public int Obwod()
        {
            return 2 * Width + 2 * Height;
        }
    }
}
