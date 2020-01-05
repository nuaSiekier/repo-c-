using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Person
    {
        public Person(string name, string surename, Adress adress)
        {
            Name = name;
            Surename = surename;
            _Adress = adress;
        }

        public Person(Adress adress)
        {
            this.adress = adress;
        }

        protected string Name;
        protected string Surename;
        public Adress _Adress;
        private Adress adress;



        //public void PrintName()
        //{
        //    Console.WriteLine($"{Name} {Surename}");
        //}

    }
}
