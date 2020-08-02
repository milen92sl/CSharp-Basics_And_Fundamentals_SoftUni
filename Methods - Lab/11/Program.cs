using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operationsNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());


            double result = 0;

            if (operation == "+")
            {
                result = n1 + n2;
                
            }
            else if (operation == "-")
            {
                result = n1 - n2;

                
            }
            else if (operation == "*")
            {
                result = n1 * n2;

                
            }
            else if (operation == "/")
            {
                result = n1 / n2;
            }

            Console.WriteLine(result);
        }
    }
}

