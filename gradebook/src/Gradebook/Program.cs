using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // double x = 25.5;
            // var y = 0.1;
            // double result = x + y;
            // System.Console.WriteLine(result);

            var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };
            // numbers[0] = 12.7;
            // numbers[1] = 12.7;
            // numbers[2] = 12.7;

            // var sum = numbers[0] + numbers[1] + numbers[2] + numbers[3];
            var sum = 0.0;

            foreach (double number in numbers)
            {
                sum += number;
            }
            System.Console.WriteLine(sum);

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }

        }
    }
}
