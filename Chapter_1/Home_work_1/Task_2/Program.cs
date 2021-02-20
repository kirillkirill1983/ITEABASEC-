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
            const double PI = 3.14;
            Console.WriteLine("Введите радиус");
            int radiusStart = Convert.ToInt32(Console.ReadLine());
            var squareTotal = Math.Pow((PI * radiusStart),2);
            Console.WriteLine("Площадь круга {0}",squareTotal);
            Console.ReadKey();
        }
    }
}
