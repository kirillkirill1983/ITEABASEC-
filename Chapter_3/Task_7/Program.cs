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
            Console.WriteLine("введите ширину");
            var lengthRectangle = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("введите длину");
            var widthRectangle = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lengthRectangle; i++)
            {
                
                for (int j = 0; j < widthRectangle; j++)
                {
                    Console.Write(" * ");
                    
                }
                Console.WriteLine();
                
            }

            Console.ReadKey();
        }
    }
}
