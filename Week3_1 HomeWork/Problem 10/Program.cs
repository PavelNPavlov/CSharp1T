/*Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/
using System;
using System.Collections.Generic;

namespace Problem_10
{
    class Fibonacci
    {
        static void Main()
        {
        Start:
            try
            {
            Input://Label, can be used with goto comand
                int numberInSequence = int.Parse(Console.ReadLine());

            SetUP:
                List<int> fibonacci = new List<int>(); //Dynamic list to hold the needed number of elements with a minumum of two for the starter 0, 1
                fibonacci.Add(0);
                fibonacci.Add(1);
                if(numberInSequence>2) {goto Process;} //if more than two elements are needed go to process to calcualte them
                else {goto Output;} //else continue to output
            Process:
                
                for (int i = 2; i <= numberInSequence; i++)
                {
                    fibonacci.Add(fibonacci[i - 2] + fibonacci[i - 1]); //calculate fibonacci series to a given element
                }
            Output:
                for (int j=0; j<numberInSequence; j++)
                {
                    if (j == numberInSequence - 1) { Console.Write(fibonacci[j]); break; }
                    Console.Write(fibonacci[j] + ", ");
                }//output needed number of elements
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please try Again!");
                goto Start;
            }

        RunAgain:
            Console.WriteLine("\nIf you wish to run the program again press y");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
