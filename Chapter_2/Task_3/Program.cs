using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение времени от 0 .. 59");
            int timeEnter = Convert.ToInt32(Console.ReadLine());

            if (timeEnter < 15)
            {
                Console.WriteLine("Первая четверть ");
            }
            else if (timeEnter >= 15 && timeEnter < 30)
            {
                Console.WriteLine("Вторая четверть");
            }
            else if (timeEnter >= 30 && timeEnter < 45)
            {
                Console.WriteLine("Третья четверть");
            }
            else
            {
                Console.WriteLine("Четвертая четверть");
            }

            Console.ReadKey();
        }
    }
}
