﻿using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();

            System.Console.WriteLine($"The average grade is {stats.Average:N1} \nThe highest is {stats.High} \nThe lowest is {stats.Low}");

        }
    }
}
