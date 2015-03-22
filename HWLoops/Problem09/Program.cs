/*Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.*/

using System;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                int matrixD = int.Parse(Console.ReadLine());

                for(int y=1; y<=matrixD;y++)
                {
                    for(int x=y; x<(y+matrixD);x++)
                    {
                        Console.Write(x + " ");
                    }
                    Console.Write("\n");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid Input format");
            }
            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
