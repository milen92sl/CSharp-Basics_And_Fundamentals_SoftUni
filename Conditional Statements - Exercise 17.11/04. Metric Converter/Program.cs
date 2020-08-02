using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberForConvert = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            if (inputMetric == "mm")
            {
                numberForConvert /= 1000;
            }
            else if (inputMetric == "cm")
            {
                numberForConvert /= 100;
            }
            if (outputMetric == "mm")
            {
                numberForConvert *= 1000;
            }
            else if (outputMetric == "cm")
            {
                numberForConvert *= 100;
            }
            Console.WriteLine($"{numberForConvert:f3}");
        }
    }
}
