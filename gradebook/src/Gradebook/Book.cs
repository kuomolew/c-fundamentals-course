using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }

        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();


            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            //foreach loop
            // foreach (double grade in grades)
            // {
            //     result.High = Math.Max(grade, result.High);
            //     result.Low = Math.Min(grade, result.Low);
            //     result.Average += grade;
            // }

            // do while loop
            // int index = 0;
            // do
            // {
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.Average += grades[index];
            //     index++;
            // }
            // while (index < grades.Count);

            // while loop
            // int index = 0;
            // while (index < grades.Count)
            // {
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.Average += grades[index];
            //     index++;
            // }


            // for loop
            for (var index = 0; index < grades.Count; index++)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
            }


            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades;
        public string Name;
    }
}
