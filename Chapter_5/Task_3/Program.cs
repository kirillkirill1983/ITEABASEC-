using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayA =new char[5];
            char[] arrayB = new char[5];
            char[] arrayTemp = new char[5];
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine("Enter Char=>");
                arrayA[i] = Convert.ToChar(Console.ReadLine());
            }

            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayB[i] = arrayA[(arrayA.Length-1) - i];
               
            }
            for (int i = 0; i < arrayB.Length; i++)
            {
                Console.WriteLine($"array[{i}] => {arrayB[i]}");
            }
            Console.ReadKey();

        }
    }
}
