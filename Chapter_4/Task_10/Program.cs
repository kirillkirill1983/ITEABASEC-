using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число  => ");
            var namberEnter = Convert.ToInt32(Console.ReadLine());

            var result= NamberRead(namberEnter);
            Console.WriteLine(result);

            Console.ReadKey();
        }
        static int NamberRead(int x)
        {
            
            if (x < 9)
            {
                return 1;
            }
            else
                return NamberRead(x/10)+1;


        }
    }
}
