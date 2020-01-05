using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
   public class Animal
    {
        public Animal (string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        protected string Name;
        protected string Sound;

        public void MakeSound()
        {
            Console.WriteLine("test");
        }
    }

}
