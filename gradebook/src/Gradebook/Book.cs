using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {

            grades.Add(grade);

        }
        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /= grades.Count;
            System.Console.WriteLine($"The average grade is {result:N1} \nThe highest is {highGrade} \nThe lowest is {lowGrade}");


        }

        private List<double> grades;
    }
}
