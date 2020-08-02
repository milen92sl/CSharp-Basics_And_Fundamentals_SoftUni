using System;

namespace GiftBox_Coverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeOfSide = double.Parse(Console.ReadLine());

            double numOfSheetsOfPaper = double.Parse(Console.ReadLine());

            double singleSheetPaperCovers = double.Parse(Console.ReadLine());


            double sides = 6;

            double areaOfTheGiftBox = sizeOfSide * sizeOfSide * sides;

            double thirdSheets = Math.Floor(numOfSheetsOfPaper / 3);

            double sheetsArea = (numOfSheetsOfPaper - thirdSheets * 0.75) * singleSheetPaperCovers;

            double percentage = (sheetsArea * 100 / areaOfTheGiftBox);

            Console.WriteLine($"You can cover {percentage:f2}% of the box.");
        }
    }
}
