using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение угла");
            var angleTotal= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Синус угла {Math.Sin(angleTotal)}");
            Console.ReadKey();

        }
    }
}
