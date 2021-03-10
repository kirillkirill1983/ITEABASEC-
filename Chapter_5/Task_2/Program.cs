using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Item=>");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = array.Length-1; i>=0; --i)
            {
                Console.WriteLine($"array[{i}]=> {array[i]} ");
            }

            Console.ReadKey();
            
        }
    }
}
