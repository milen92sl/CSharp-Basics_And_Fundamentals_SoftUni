﻿using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
             
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double squareArea = a * a;
                Console.WriteLine($"{squareArea:f3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double rectangleArea = a * b;
                Console.WriteLine($"{rectangleArea:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * (radius * radius);
                Console.WriteLine($"{circleArea:f3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double triangleArea = (a * b) / 2;
                Console.WriteLine($"{triangleArea:f3}");
            }
        }
    }
}
