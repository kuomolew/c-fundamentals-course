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
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //will be done anyway
                }


            };

            var stats = book.GetStatistics();

            System.Console.WriteLine($"The average grade is {stats.Average:N1} \nThe highest is {stats.High} \nThe lowest is {stats.Low} \nThe letter grade is {stats.Letter}");

        }
    }
}
