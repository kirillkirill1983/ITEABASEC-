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
            Console.Write("Введите перво число => ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число=> ");
            int value2 = Convert.ToInt32(Console.ReadLine());
            
            Calculator.Plus(value1, value2);

            Calculator.Minus(value1, value2);

            Console.ReadKey();
        }
    }
}
