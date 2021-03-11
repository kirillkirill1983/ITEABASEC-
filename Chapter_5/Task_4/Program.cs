using System;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово =>");
            string word = Convert.ToString(Console.ReadLine());
            ConverWodrd(word);

            Console.ReadKey();
        }

        static  void ConverWodrd(string msg ) 
        {
            char[] reversWord = msg.ToCharArray();
            Array.Reverse(reversWord);
            string newWord = new string(reversWord);
            Console.WriteLine(newWord);
        }
    }
}