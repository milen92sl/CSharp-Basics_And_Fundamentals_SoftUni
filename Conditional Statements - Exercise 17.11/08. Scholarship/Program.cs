using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double results = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double scholarshipS = minSalary * 35 / 100;
            double scholarshipE = results * 25;
            if (results >= 5.5)
            {
                if (scholarshipE >= scholarshipS || income > minSalary)
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(scholarshipE));
                else Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarshipS));
            }
            else if (income < minSalary && results > 4.5)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarshipS));
            }

            else Console.WriteLine("You cannot get a scholarship!");
        }
    }
}












