/*Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.*/

using System;


namespace HWLoops
{
    class Nnumbers
    {
        static void Main()
        {
        Start:
            try
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    if (i == 1)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(" {0}", i);
                    }
                }
                Console.Write("\n");
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input format");
            }

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
