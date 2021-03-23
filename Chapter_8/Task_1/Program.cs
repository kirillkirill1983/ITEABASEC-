using System;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            Journal journal1 = new Journal();
            Journal journal2 = new Journal();

            Book book = new Book();
            Book book1 = new Book();

            IPrintable[] printables = { journal, book,journal1,journal2,book1 };

            Magazine magazine = new Magazine();

            magazine.printMagazine(printables);

            Console.WriteLine(new string('-', 10));

            book.printBooks(printables);

            Console.WriteLine(new string('-', 10));

            Console.ReadKey();
        }
    }
}
