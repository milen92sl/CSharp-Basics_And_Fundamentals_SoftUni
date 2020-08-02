using System;

namespace _08._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата плод (banana / apple / orange / grapefruit / kiwi /
            //pineapple / grapes), ден от седмицата(Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday 
            //и количество (реално число) , въведени от потребителя, и пресмята цената според
            //цените от таблиците по-горе.
            string fruit = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday")
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.50;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "apple")
                {
                    price = quantity * 1.20;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "orange")
                {
                    price = quantity * 0.85;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "grapefruit")
                {
                    price = quantity * 1.45;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "kiwi")
                {
                    price = quantity * 2.70;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "pineapple")
                {
                    price = quantity * 5.50;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "grapes")
                {
                    price = quantity * 3.85;
                    Console.WriteLine("{0:f2}", price);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (weekDay == "Saturday" || weekDay == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.70;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "apple")
                {
                    price = quantity * 1.25;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "orange")
                {
                    price = quantity * 0.90;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "grapefruit")
                {
                    price = quantity * 1.60;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "kiwi")
                {
                    price = quantity * 3.00;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "pineapple")
                {
                    price = quantity * 5.60;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "grapes")
                {
                    price = quantity * 4.20;
                    Console.WriteLine("{0:f2}", price);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
