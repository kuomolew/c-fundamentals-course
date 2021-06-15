using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 25.5;
            var y = 0.1;
            double result = x + y;
            System.Console.WriteLine(result);

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
