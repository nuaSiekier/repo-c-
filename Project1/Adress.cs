using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Adress
    {
        public string Country;
        public string City;
        public string Street;
        public Cities Cities;
        public Countries Countries;


        public Adress(string country, string city, string street, Countries countries, Cities cities)
        {
            Country = country;
            City = city;
            Street = street;
            Countries = countries;
            Cities = cities;

        }
    }
}
