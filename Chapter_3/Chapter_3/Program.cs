using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine($"Значение {i}");
                i++;
               
            }
            ////////////////
            do
            {
                Console.WriteLine($"Значение {i}");
                i++;
            } while (i<5);
            ///////////////
            for (int y= 0; y < 5; y++)
            {
                Console.WriteLine($"Значение {y}");
                
            }

            Console.ReadKey();
        }
    }
}
