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
            Console.Write("Ведите число фибоначи=> : ");
            int fibonachiNamber = Convert.ToInt32(Console.ReadLine());

            int f1 = 0;
            int f2 = 1;
            for (int i = 0; i < fibonachiNamber; i++)
            {
                int fib = f1 + f2;
                Console.WriteLine(fib);
                f1 = f2;
                f2 = fib;
            }
            Console.ReadKey();

        }
    }

}