using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной А");
            int literalEnter = Convert.ToInt32(Console.ReadLine());

            if (literalEnter < 10)
            {
                Console.WriteLine("Верно {0}", literalEnter);
            }
            else 
            {
                Console.WriteLine("Неверно {0}", literalEnter);
            }
            Console.ReadKey();
        }
    }
}
