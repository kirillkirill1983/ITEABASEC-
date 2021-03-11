using System;
using System.Linq;


namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива=> ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            int[,] oneArray = new int[sizeArray ,sizeArray ];
            
            for (int i = 0; i <sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    oneArray[i, j] = rnd.Next(0, 20);
                }
            }
            
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    Console.Write($"{oneArray[i, j]} \t");  
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма элементов каждой строки");

            int[] sum = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    sum[i] += oneArray[i, j];
                }
            }

            Console.WriteLine("==================");

            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine(sum[i]);
            }

            Console.WriteLine("==================");

            int[]  mult= new int[sizeArray];

            for (int i = 0; i < mult.Length; i++)
            {
                mult[i] = 1;
            }

            Console.WriteLine("Произведение элементов столбца");

            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    mult[i]*= oneArray[j, i];
                }
            }

            for (int i = 0; i < mult.Length; i++)
            {
                Console.WriteLine(mult[i]);
            }

            int[] sumDiagonal = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    if (i==j)
                    {
                        sumDiagonal[i] = oneArray[i, j];
                    }
                }
            }
            Console.WriteLine("=====================");
            Console.WriteLine("Максимальное значение диагонали {0}",sumDiagonal.Max());
            Console.ReadKey();
        }
    }
}
