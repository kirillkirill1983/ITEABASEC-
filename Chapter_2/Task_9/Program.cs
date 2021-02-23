using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите одно из слов Один Два Три  Четыре " +
                "Пять Шесть Семь Восемь Девять Десять ");
            string wordTranslate = Console.ReadLine();
            //one two three four five six seven eight nine ten
            switch (wordTranslate)
            {
                case "Один":
                    Console.WriteLine("one");
                    break;
                case "Два":
                    Console.WriteLine("two");
                    break;
                case "Три":
                    Console.WriteLine("three");
                    break;
                case "Четыре":
                    Console.WriteLine("four");
                    break;
                case "Пять":
                    Console.WriteLine("five");
                    break;
                case "Шесть":
                    Console.WriteLine("six");
                    break;
                case "Семь":
                    Console.WriteLine("seven");
                    break;
                case "Восемь":
                    Console.WriteLine("eight");
                    break;
                case "Девять":
                    Console.WriteLine("nine");
                    break;
                case "десять":
                    Console.WriteLine("ten");
                    break;

                default:
                    Console.WriteLine("ErrroR");
                    break;
            }
            Console.ReadKey();
            
        }
    }
}
