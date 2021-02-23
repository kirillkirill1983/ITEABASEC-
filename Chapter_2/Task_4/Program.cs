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
            Console.WriteLine("ВВедите число ");
            int namberEnter = Convert.ToInt32(Console.ReadLine());

            if (namberEnter % 2 == 0)
            {
                Console.WriteLine("Четное");

                if (namberEnter % 3 == 0 && namberEnter % 6 == 0)
                {
                    Console.WriteLine("Делиться на 3 и на 6 ");
                }
            }

            else if (namberEnter % 3 == 0  )
            {
                Console.WriteLine("Делиться на 3");
            }

            else if (namberEnter % 6 == 0)
            {
                Console.WriteLine("Делиться на 6");
            }

            else
            {
                Console.WriteLine("Нечетное");
            }

            Console.ReadKey();
        }
    }
}
