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
            int[] primerArray = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < primerArray.Length; i++)
            {
                Console.Write($" {primerArray[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("введите индекс с которого создать новый массив");

            int newIndex = Convert.ToInt32(Console.ReadLine());

            resultArray(primerArray,newIndex,5,out int[] result);
            
            Console.WriteLine();
            Console.WriteLine("Result=>");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(" {0}",result[i]);
            }
            Console.ReadKey();
        }
        static void resultArray(int[] array,int index,int count,out int[] subArray) 
        {
            int[] temp = new int[count-index];
            
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = array[index+i];
            }
           
            subArray = temp;
            
        }
    }
}
