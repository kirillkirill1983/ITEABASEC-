using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первого катета");
            var legOne= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение второго катета");
            var legTwo = Convert.ToInt32(Console.ReadLine());
            var hypotenuseTotal = Math.Sqrt((Math.Pow(legOne, 2)+Math.Pow(legTwo,2)));
            Console.WriteLine("Гипотенуза {0}", hypotenuseTotal);
            Console.ReadKey();
        }
    }
}
