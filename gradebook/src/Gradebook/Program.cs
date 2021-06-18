using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Vova");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;

                }
                var grade = double.Parse(input);
                book.AddGrade(grade);
            };

            var stats = book.GetStatistics();

            System.Console.WriteLine($"The average grade is {stats.Average:N1} \nThe highest is {stats.High} \nThe lowest is {stats.Low} \nThe letter grade is {stats.Letter}");

        }
    }
}
