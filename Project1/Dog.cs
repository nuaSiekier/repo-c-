using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Dog : Animal
    {
        public Dog(string name, string sound, string smycz) : base(name, sound)
        {
            Smycz = smycz;
        }
        protected string Smycz;

        void gryz()
        {

        }
    }
}
