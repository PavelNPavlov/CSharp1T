/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/

using System;
using System.Collections.Generic;
using System.Linq; //allows min max.... for arrays, lists...

namespace MaxMinSumAvG
{
    class Program
    {
        static void Main()
        {
            Start:
            try 
            { 
                int numberInput=int.Parse(Console.ReadLine());

                List<int> numbers= new List<int>();

                for(int i=0; i<numberInput; i++)
                {
                    numbers.Add(int.Parse(Console.ReadLine()));
                }

                int max = numbers.Max();
                int min = numbers.Min();
                int sum = numbers.Sum();
                double avg =Math.Round( numbers.Average(),2);

                Console.WriteLine("min = {0}", min);
                Console.WriteLine("max = {0}", max);
                Console.WriteLine("sum = {0}", sum);
                Console.WriteLine("avg = {0}", avg);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input format");
            }
            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
