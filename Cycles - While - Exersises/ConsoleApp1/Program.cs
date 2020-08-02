using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int numberOfBooks = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isBookFound = false;


            string nextBookName = Console.ReadLine();

            while (counter < numberOfBooks)
            {
                if (nextBookName == favouriteBook)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();

            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it."  );
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numberOfBooks} books.");

            }
        }
    }
}
