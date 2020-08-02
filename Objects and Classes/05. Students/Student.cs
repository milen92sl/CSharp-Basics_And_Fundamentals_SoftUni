using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Students
{
    class Student
    {

        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age} {City}";
        }
    }
}
