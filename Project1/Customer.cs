using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Customer
    {
        public Adress Adress { get; private set; }

        public Customer(Adress adress)
        {
            Adress = adress;
        }

        public Customer()
        {
        }
        
        public virtual void PrintAdress()
        {
            Console.Write(Adress.Street);
        }

    }
}
