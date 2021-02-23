using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение времени от 0 .. 100");
            int timeEnter = Convert.ToInt32(Console.ReadLine());

            //[0 - 14] [15 - 35] [36 - 50][50 - 100].
            
            switch (timeEnter)
            {
                case int n when ( n<= 14) :
                    Console.WriteLine("Первая часть от [0-14]");
                    break;
                case int n when (n >= 15 && n <=35):
                    Console.WriteLine("Вторая часть от [15-35]");
                    break;
                case int n when(n >= 36 && n <= 50) :
                    Console.WriteLine("Третья часть от [36-50]");
                    break;
                case int n when (n >= 50 && n <= 100):
                    Console.WriteLine("Четвертая часть от [50-100]");
                    break;

                default:
                    Console.WriteLine("Вне диапазона чисел");
                    break;
            }


            Console.ReadKey();
        }
    }
}
