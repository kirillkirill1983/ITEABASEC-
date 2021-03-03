using System;


namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год рождение");
            var ageNow = Convert.ToInt32(Console.ReadLine());
            Console.Write(AgeTotal(ageNow));
            Console.ReadKey();
        }

        public static string AgeTotal(int age)
        {
            DateTime dateNow = DateTime.Now;
            var totalAge = dateNow.AddYears(-age);
            Console.Write("Ваш возраст => ");
            return totalAge.Year.ToString();
        }

    }
}
