using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ЧИСЛО");
            var namberEnter = Convert.ToInt32(Console.ReadLine());

            var namberTotal = 0;

            for (int i = 1; i <= namberEnter; i++)
            {
                namberTotal += i;
                
            }
            Console.WriteLine("сумма {0}",namberTotal);
            Console.ReadKey();
        }
    }
}
