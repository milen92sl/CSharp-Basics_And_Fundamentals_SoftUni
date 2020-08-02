using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]
            //•	След това многократно се четат по два реда:
            //o Име на задача -текст(низ)
            //o Оценка -цяло число в интервала[2…6]
            //Изход
            //•	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда:
            //            o   "Average score: {средна оценка}"
            //o   "Number of problems: {броя на всички задачи}"
            //o   "Last problem: {името на последната задача}"
            //•	Ако получи определеният брой незадоволителни оценки:
            //o   "You need a break, {брой незадоволителни оценки} poor grades."

            int failedThresHold= int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double gradesSum = 0;
            string lastProblem = string.Empty ;
            bool isFailed = true;

            while (failedTimes < failedThresHold)
            {
                string ProblemName = Console.ReadLine();
                if (ProblemName == "Enough")
                {
                    isFailed = false;
                    break;

                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;

                }
                gradesSum += grade;
                solvedProblemsCount++;
                lastProblem = ProblemName;

            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThresHold} poor grades.");

            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedProblemsCount:f2}");
                Console.WriteLine($"Number of problems:{solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

                }
                
            }

            

        }
 