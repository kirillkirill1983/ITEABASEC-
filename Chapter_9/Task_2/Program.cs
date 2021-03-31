using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значения в цельсиях => ");
            string temperatureCel = Console.ReadLine();
            Convector.CelsiumToFahrenheit(temperatureCel);

            Console.Write("Введите значения в фаренгейтах => ");
            string temperatureFar = Console.ReadLine();
            Convector.FahrenheitToCelsium(temperatureFar);

            Console.ReadKey();
        }
    }
}
