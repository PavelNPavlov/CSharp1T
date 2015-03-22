/*Problem 12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/

using System;
using System.Collections.Generic;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                string input = Console.ReadLine();
                long number=0;
                int lenght=input.Length;
                for(int i=0; i<lenght; i++)
                {
                    int digit = (input[lenght-1-i] == '1') ? 1 : 0;
                    number += digit*(long)Math.Pow(2, i);
                    

                }

                Console.WriteLine(number);
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
