using System;

namespace CircleAreaandPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг / окръжност с радиус r, като форматирате изхода до втория знак след десетичната запетая.
            double radius = double.Parse(Console.ReadLine());
            double areaOfCircle = (Math.PI * radius * radius);
            double perimeter = (2 * Math.PI * radius);

            Console.WriteLine($"{areaOfCircle:f2}");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}
