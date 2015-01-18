/*Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.*/
using System;


namespace Problem_01
{
    class Program
    {
        static void Main()
        {
            string run = "y";
            while (run=="y")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Is integer {0} even? {1}", number, (number % 2 == 0));
                Console.WriteLine("If you wish to repeat press y ");
                run=Console.ReadLine();
            }// Повторение на програмата
        }
    }
}
