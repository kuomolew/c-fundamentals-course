using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var Book = new Book();
            Book.AddGrade(89.1);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            var result = 0.0;

            foreach (double number in grades)
            {
                result += number;
            }

            result /= grades.Count;
            System.Console.WriteLine($"The average grade is {result:N3}");

        }
    }
}
