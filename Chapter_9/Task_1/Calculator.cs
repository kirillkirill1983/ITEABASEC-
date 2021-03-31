using System;

namespace Task_1
{
    static class Calculator
    {
        static Calculator()
        {
            Console.WriteLine("Создание экзэмпляра");
        }

        public static void Plus(int value1, int value2)
        {
            Console.WriteLine($"{value1} + {value2} = {value1+value2}");
        }
        public static void Minus(int value1, int value2) 
        {
            Console.WriteLine($"{value1} - {value2} = {value1-value2}");
        }
    }
}
