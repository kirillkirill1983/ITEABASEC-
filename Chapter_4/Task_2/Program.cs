using System;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 значение = > ");
            int parametr1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 значение = > ");
            int parametr2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Меньшее значение {0} ",ReturnVariable(parametr1,parametr2));
            Console.ReadKey();
        }

        public static int ReturnVariable(int variable1,int variable2) 
        {
            if (variable1 < variable2)
            {
                Console.WriteLine("Первое число");
                return variable1; 
            }
            else if (variable2 < variable1)
            {
                Console.WriteLine("Второе число");
                return variable2;
            }
            else
                Console.WriteLine("Равно");
            return 1;
             
        }
    }
}
