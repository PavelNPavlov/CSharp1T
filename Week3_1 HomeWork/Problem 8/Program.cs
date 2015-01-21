/*Problem 8. Numbers from 1 to n

Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.*/
using System;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            try
            {
            Input://Label, can be used with goto comand
                int numberInSequence=int.Parse(Console.ReadLine());

            Output:
                for (int i=1; i<=numberInSequence;i++)
                {
                    Console.WriteLine(i);
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please try Again!");
                goto Start;
            }

        RunAgain:
            Console.WriteLine("If you wish to run the program again press y");
            if (Console.ReadLine() == "y") { goto Start; }
        }
        
    }
}
