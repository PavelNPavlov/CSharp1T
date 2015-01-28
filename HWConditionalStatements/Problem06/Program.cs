/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.*/

using System;

namespace Problem05
{
    class Biggest5
    {
        static void Main(string[] args)
        {
            double biggest=0;
            double[] numbers = new double[5];
        Start:
            try
            {
                for (int i = 0; i < 5; i++ )
                {
                    numbers[i] = double.Parse(Console.ReadLine());
                    if (i == 0) 
                    {
                        biggest = numbers[i];
                    }

                    if (numbers[i]>biggest && i!=1)
                    {
                        biggest = numbers[i];
                    }
                }

            Console.WriteLine(biggest);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
