using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = int.Parse(Console.ReadLine());
            decimal p = int.Parse(Console.ReadLine());

            decimal courses = Math.Ceiling(n / p);

            Console.WriteLine(courses);
        }
    }
}
