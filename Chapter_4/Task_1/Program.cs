using System;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 значение = > ");
            int parametr1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 значение = > ");
            int parametr2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 3 значение = > ");
            int parametr3 = Convert.ToInt32(Console.ReadLine());
            
            var result= Meen(parametr1,parametr2,parametr3);

            Console.WriteLine($"Среднее значение {result}");
        
            Console.ReadKey();
            
        }
        /// <summary>
        /// Поиск среднего по 3 значениям
        /// </summary>
        /// <param name="variabl1"> Первый элемент</param>
        /// <param name="variable2"> второй элемент</param>
        /// <param третье name="variable3"> Третий  элемент</param>
        /// <returns> Среднее значение</returns>
        public static int Meen(int variabl1,int variable2,int variable3) 
        {
            return (variabl1 + variable2 + variable3 + variable3) / 3;
        }
    }
}
