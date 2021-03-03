using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число  => ");
            var namberEnter = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine(NamberRead(namberEnter));

            Console.ReadKey();
        }
        static int NamberRead(int x)
        {
            
            if (x<=0)
            {
                return 0;
            }
            else
                return x + (NamberRead(x - 1));

        }
    }
}
