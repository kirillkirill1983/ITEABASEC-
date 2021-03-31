using System;


namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str = "Выходные= пиво + сон";
            int result= StringExtension.StrCount(Str,2);
            Console.WriteLine($"{result }");

            Console.WriteLine(new string('-', 10));

            Console.WriteLine(Str.StrCount(2).ToString());

            Console.ReadKey();
        }
    }
}
