using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalsteps = 0;

            while (input != "Going home")
            {
                if (totalsteps >= 10000)
                {
                    break;
                }
                totalsteps += int.Parse(input);
                input = Console.ReadLine();


            }
            if (input == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                totalsteps += stepsToHome;
            }
            if (totalsteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalsteps} more steps to reach goal.");
            }


        }
    }
}
