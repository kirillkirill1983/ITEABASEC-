using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //    Напишите программу расчета начисления премий сотрудникам.
        //    Премии рассчитываются  согласно выслуге лет. Если
        //     выслуга до 5 лет, премия составляет 10% от заработной платы.
        //        Если выслуга от 5 лет (включительно) до 10 лет, 
        //        премия составляет 15% от заработной платы.
        //        Если выслуга от 10 лет (включительно) до 15 лет, 
        //        премия составляет 25% от заработной платы.
        //        Если выслуга от 15 лет (включительно) до 20 лет, 
        //        премия составляет 35% от заработной платы.
        //        Если выслуга от 20 лет (включительно) до 25 лет, 
        //        премия составляет 45% от заработной платы.
        //        Если выслуга от 25 лет (включительно) и более, 
        //        премия составляет 50% от заработной платы.
        //        Результаты расчета, выведите на экран.
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите свой стаж работы");

            var workExperience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите свою зароботную плату");

            var moneyEasy = Convert.ToInt32(Console.ReadLine());

            switch (workExperience)
            {
                case int n when (n <5):
                    Console.WriteLine($"Ваша премия c зарплатой = {moneyEasy*1.1}");
                    break;
                case int n when (n >= 5 && n <10 ):
                    Console.WriteLine($"Ваша премия c зарплатой = {moneyEasy * 1.15}");
                    break;
                case int n when (n >= 10 && n < 15):
                    Console.WriteLine($"Ваша премия c зарплатой = {moneyEasy * 1.25}");
                    break;
                case int n when (n >=15 && n < 20):
                    Console.WriteLine($"Ваша премия c зарплатой = {moneyEasy * 1.35}");
                    break;
                case int n when (n >= 20 && n < 25):
                    Console.WriteLine($"Ваша премия c зарплатой = {moneyEasy * 1.45}");
                    break;
                case int n when (n >= 25 && n < 100):
                    Console.WriteLine($"Ваша премия c зарплатой = {moneyEasy * 1.50}");
                    break;

                default:
                    Console.WriteLine("Ошибка ввода вы на пенсии или в садике ");
                    break;
            }

            Console.ReadKey();
        }
    }
}
