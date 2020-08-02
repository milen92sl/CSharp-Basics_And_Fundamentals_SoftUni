using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Day_of_Week
{
    class Cat
    {
        public int Age;

        public double Fat { get; internal set; }

        public void Eat()
        {
            Fat += 200;
        }
        
       
    }
}
