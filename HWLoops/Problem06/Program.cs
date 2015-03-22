/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.*/

using System;


namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                int n = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                int factorialN = 1;
                int factorialX = 1;

                int countX = 1;
                int countN = 1;
                while(true)
                {
                    if(countN<=n)
                    {
                        factorialN *= countN;
                        countN++;
                    }

                    if (countX <= x)
                    {
                        factorialX *= countX;
                        countX++;
                    }

                    if(countN>n && countX>x)
                    {
                        break;
                    }
                }
                double result = factorialN / factorialX;
                Console.WriteLine(result);

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
