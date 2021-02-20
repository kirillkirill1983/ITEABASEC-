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
            Console.WriteLine("Введите первое число");
            var oneTotal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var twoTotal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{oneTotal} + {twoTotal} = {oneTotal+twoTotal}");
            Console.WriteLine($"{oneTotal} - {twoTotal} = {oneTotal - twoTotal}");
            Console.WriteLine($"{oneTotal} * {twoTotal} = {oneTotal * twoTotal}");
            Console.WriteLine($"{oneTotal} / {twoTotal} = {oneTotal / twoTotal}");
            Console.ReadKey();
        }
    }
}
