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
            Console.WriteLine("Введите а");
            int alfaEnter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int betaEnter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c");
            int ciEnter = Convert.ToInt32(Console.ReadLine());

            var dicretRezult = Math.Pow(betaEnter,2)-4*alfaEnter*betaEnter ;

            if (dicretRezult > 0)
            {
                Console.WriteLine("Уравнение имеет два решение");
                var oneTotal = (-betaEnter + Math.Sqrt(dicretRezult)) / (2 * alfaEnter);
                var twoTotal = (-betaEnter - Math.Sqrt(dicretRezult)) / (2 * alfaEnter);
                Console.WriteLine(" Первое решение {0} второе решение{1} ", oneTotal, twoTotal);
            }
            else if (dicretRezult == 0)
            {
                Console.WriteLine("Уравнение имеет одно решение");
                var oneTotal = -betaEnter / (2 * alfaEnter);
                Console.WriteLine("Решение {0}", oneTotal);
            }
            else
            {
                Console.WriteLine("Нет решения");
            }

            Console.ReadKey();
        }
    }
}
