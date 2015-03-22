/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).*/

using System;
using System.Numerics;


namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                int n = int.Parse(Console.ReadLine());
                int ntimes2 = 2 * n;
                int nplus1 = n + 1;
                BigInteger factorialN = 1;
                BigInteger factorial2N = 1;
                BigInteger factorialN1 = 1;

                int count2N = 1;
                int countN = 1;
                int countN1 = 1;
                while (true)
                {
                    if (countN <= n)
                    {
                        factorialN *= countN;
                        countN++;
                    }

                    if (count2N <= ntimes2)
                    {
                        factorial2N *= count2N;
                        count2N++;
                    }

                    if (countN1 <= nplus1)
                    {
                        factorialN1 *= countN1;
                        countN1++;
                    }

                    if (countN > n && count2N > ntimes2 && countN1>nplus1)
                    {
                        break;
                    }
                }
                BigInteger result = factorial2N / (factorialN*factorialN1);
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
