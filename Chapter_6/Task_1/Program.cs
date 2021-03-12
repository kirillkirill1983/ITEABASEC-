using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            adress.House = 12;
            adress.Country = "Vavilon";
            adress.Index = 123;
            adress.City = "Borodok";
            adress.Apartment = 100;
            adress.Street = "beer_lager";
            adress.ShowAdress();
            Console.ReadKey();
        }
    }
}
