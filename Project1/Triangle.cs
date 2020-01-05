using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Triangle : Shape
    {
        public Triangle (int width, int height, int aside, int bside) : base(width, height)
        {
            Aside = aside;
            Bside = bside;
        }
        protected int Bside;
        protected int Aside;
        public int Pole()
        {
            return (Width/2) * Height;
        }
        public int Obwod()
        {
            if (Aside + Bside > Width)
            {
                return Aside + Bside + Width;
            }
            else
            {
                return 0;
            }
        }
    }
}
