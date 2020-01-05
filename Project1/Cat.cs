using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Cat : Animal

    {
        public Cat(string name, string sound, string drapak) : base(name, sound)
        {
            Drapak = drapak;
        }
        protected string Drapak;

        void podrap()
        {

        }
    }
}

