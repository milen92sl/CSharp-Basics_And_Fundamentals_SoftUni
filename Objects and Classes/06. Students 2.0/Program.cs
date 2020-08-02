using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] data = input.Split();
                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string city = data[3];
                Student student = new Student(firstName, lastName, age, city);
                // {
                //    FirstName = firstName
                //    LastName = lastName
                //    Age = age
                //    City = city
                // };
                students.Add(student);
                input = Console.ReadLine();
            }
            string chosenCity = Console.ReadLine();

            static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
            {
                foreach (Student student in students)
                {
                    if (student.FirstName == firstName && student.LastName == lastName)
                    {
                        return true;
                    }

                }
                return false;

            }
            if (IsStudentExisting(students, firstName, lastName))
            {
                Student student = GetStudent(students, firstName, lastName)
            }
            static Student GetStudent(List<Student> students, string firstName, string lastName)


                Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }

                return existingStudent;
            }

            if (IsStudentExisting(students, firstName, lastName))
            {
                Student student = GetStudent(students, firstName, lastName);
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.City = city;
            }
        }
    }

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