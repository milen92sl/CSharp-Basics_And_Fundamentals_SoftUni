using System;

namespace _07._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double gradeRate = 1;
            double averageGrade = 0;

            while (gradeRate <= 12)
            {
              double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    averageGrade += grade;
                    gradeRate++;
                    
                }  
            }
            double totalgrade = averageGrade / 12;
            Console.WriteLine($"{name} graduated. Average grade: {totalgrade:f2}");



        }
    }
}
