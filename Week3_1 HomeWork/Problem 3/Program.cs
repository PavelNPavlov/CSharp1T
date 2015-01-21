/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/

using System;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
        Start:
            try
            {
            Input:
                double r = double.Parse(Console.ReadLine());
            Output:
                Console.WriteLine(Math.Round(2*Math.PI*r,2));
                Console.WriteLine(Math.Round(Math.PI * Math.Pow(r,2),2));
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please try Again!");
                goto Start;
            }
            Console.WriteLine("If you wish to run the program again press y");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
