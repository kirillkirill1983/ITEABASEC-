using System;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cash=new int[5];
            for (int i = 0; i < cash.Length; i++)
            {
                Console.WriteLine($"Введите прибыль фирмы за {i+1} месяц");
                cash[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("==========================");
            Console.WriteLine("Ведите первый месяц начала поиска ");
            var oneMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ведите второй месяц начала поиска ");
            var twoMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================\n");
            int min = cash[oneMonth-1];
            int indexMin = 0;
            int max = cash[oneMonth-1];
            int indexMax = 0;
            for (int i = oneMonth-1; i < twoMonth; i++)
            {
                if (min>=cash[i])
                {
                    min = cash[i];
                    indexMin = i;
                }
                if (max<=cash[i])
                {
                    max = cash[i];
                    indexMax = i;
                }
            }
            Console.WriteLine($"Min {min} month {indexMin+1}");
            Console.WriteLine($"Max {max} month {indexMax+1}");

            Console.ReadKey();
        }
    }
}
