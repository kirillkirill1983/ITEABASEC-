using System;
using System.Linq;


namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива=> ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            int[] randomArray = new int[sizeArray];
            for (int i = 0; i < randomArray.Length; i++)
            {
                
                randomArray[i]= rnd.Next(0,20);
            }

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.Write(" {0} <==> ",randomArray[i].ToString());
            }
            
            Console.WriteLine("===================================\n");
            Console.WriteLine(randomArray.Max());
            Console.WriteLine(randomArray.Min());
            Console.WriteLine (randomArray.Sum());
            Console.WriteLine("{0:f2}",(double)((randomArray.Sum() / randomArray.Length)));
            Console.WriteLine("Нечетное значение");
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i]%2!=0)
                {
                    Console.Write(" {0}",randomArray[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
