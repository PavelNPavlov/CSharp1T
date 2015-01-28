/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.*/
using System;

namespace Problem05
{
    class Biggest
    {
        static void Main(string[] args)
        {
            double a, b, c, biggest;
        Start:
            try
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());

                biggest = a;

                if (b > biggest) { biggest = b; }

                if (c > biggest) { biggest = c; }

                Console.WriteLine(biggest);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
