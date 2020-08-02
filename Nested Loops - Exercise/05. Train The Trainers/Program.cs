using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // number of judges


            string input = Console.ReadLine();

            double totalSum = 0;
            int numberOfContenstants = 0;
            while (input != "Finish")
            {
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                }
                double averageGrade = sum / n;
                totalSum += averageGrade;
                Console.WriteLine($"{input} - {averageGrade:f2}.");
                numberOfContenstants++;
                input = Console.ReadLine();
            }

            double totalAverageGrade = totalSum / numberOfContenstants;
            Console.WriteLine($"Student's final assessment is {totalAverageGrade:f2}.");

        }
    }
}