using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal area = a * b;
            if (area <= 0)
            {
                Console.WriteLine("Area is not valid, please enter the correct values");
            }
            else
            {
                Console.Write("Area is:");   //!!!Когато тук е Console.WriteLine(area);  ми печата пресметнатото.

                Console.WriteLine(area);
            }
        }
    }
}
