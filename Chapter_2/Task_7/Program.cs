using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            var oneTotal = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите второе число");
            var twoTotal = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите арифметическую операцию");
            string sign = Console.ReadLine();
            
            switch (sign)
            {
                case "+":
                    Console.WriteLine($"{oneTotal} + {twoTotal} = {oneTotal+twoTotal} ");
                    break;
                case "-":
                    Console.WriteLine($"{oneTotal} - {twoTotal} = {oneTotal - twoTotal} ");
                    break;
                case "*":
                    Console.WriteLine($"{oneTotal} * {twoTotal} = {oneTotal * twoTotal} ");
                    break;
                case "/":
                    Console.WriteLine($"{oneTotal} / {twoTotal} = {oneTotal / twoTotal} ");
                    break;

                default:
                    Console.WriteLine("Такой операции нет ");
                    break;
            }

            Console.ReadKey();

        }
    }
}
