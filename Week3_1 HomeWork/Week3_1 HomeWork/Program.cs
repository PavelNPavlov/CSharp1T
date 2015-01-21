/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prdoubles their sum.*/

using System;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            Start:
            try
            {
                Input: 
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                Output:
                    Console.WriteLine(a + b + c);
            }

            catch(FormatException)
            {
                Console.WriteLine("Invalid input format. Please try Again!");
                goto Start;
            }
            Console.WriteLine("If you wish to run the program again press y");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
