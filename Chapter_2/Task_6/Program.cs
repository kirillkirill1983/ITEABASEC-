using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Год");
            var yearEnter = Convert.ToInt32(Console.ReadLine());

            if (yearEnter % 4 == 0)
            {
                Console.WriteLine("Год высокосный");
                if (yearEnter % 400 == 0)
                {
                    Console.WriteLine("Год высокосны делиться на 400");
                }
            }
            else
            {
                Console.WriteLine("Год НЕ Высокосный");
            }
            Console.ReadKey();   
        }
    }
}
