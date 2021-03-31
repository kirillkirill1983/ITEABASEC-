using System;



namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraySort = IntExtension.IntRandom(5);
            for (int i = 0; i < arraySort.Length; i++)
            {
                Console.Write($" {arraySort[i] }");
            }

            Console.WriteLine("\n {0}",new string('-', 10));
            arraySort.IntSort();
            for (int i = 0; i < arraySort.Length; i++)
            {
                Console.Write($" {arraySort[i]} ");
            }

            Console.ReadKey();
        }
        
    }
}
