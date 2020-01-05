using System;

using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Employee : Customer
    {

        public Employee(Adress adress) : base(adress)
        {
        }

        public override void PrintAdress()
        {
            Console.WriteLine($"{Adress.Street}, {Adress.Country}, {Adress.City}");
        }
    





    //    public Employee (string name, string surname, int age)
    //    {

    //    }
    //    private string name;
    //    private string surename;
    //    private int age;

    //    public string Name
    //    {
    //        get { return name; }
    //        private set
    //        {
    //            if (value.Length > 3 && value.Length < 100)
    //                name = value;
    //        }
    //    }

    //    public string Surename
    //    {
    //        get { return surename; }
    //        private set
    //        {
    //            if (value.Length > 4 && value.Contains("z"))
    //            {
    //                surename = value;
    //            }
    //        }
    //    }

    //    public int Age
    //    {
    //        get { return age; }
    //        private set
    //        {
    //            if (value > 18 && value < 150)
    //                age = value;
    //        }
    //    }
}
}
