﻿using System;

namespace _01.Day_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[]{
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int day = int.Parse(Console.ReadLine());
            if (day >=1 && day <= 7)
            {
                Console.WriteLine(daysOfWeek[day-1]);

            }
            else
            {
                Console.WriteLine("Invalid day!"); 
            }
        }
    }

}




