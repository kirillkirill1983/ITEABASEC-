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
            Console.Write("Введите число вывода раз => ");
            var namberEnter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(NamberRead(namberEnter));

            Console.ReadKey();
        }
        static int NamberRead(int x)
        {
            if (x == 1)
            {
                Console.WriteLine("------");
                return 1;
            }
            else
                Console.WriteLine("------");
                Console.WriteLine(x);
                return NamberRead(--x);


        }
    }
}
