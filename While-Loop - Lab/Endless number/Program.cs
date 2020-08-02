using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int s = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > s)
                {
                    s = number;
                }
            }
            Console.WriteLine(s);
        }
    }
}