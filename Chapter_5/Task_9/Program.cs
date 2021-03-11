using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startArray = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Исходный массив ");
            for (int i = 0; i < startArray.Length; i++)
            {
                Console.Write($" {startArray[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("введите числодля добавления");
            int namberPlus = Convert.ToInt32(Console.ReadLine());
            PlusArray(startArray, namberPlus, out int[] result);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($" {result[i]}");
            }

            Console.ReadKey();
        }
        static void PlusArray(int[] array, int value,out int[] result )
        {
            int[] temp = new int[array.Length + 1];
            temp[0] = value;
            Console.WriteLine("Результат добавления");
            for (int i = 0; i < array.Length; i++)
            {
                temp[i+1] = array[i];
            }
            result = temp;
        }
    }
}
