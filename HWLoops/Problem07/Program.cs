/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.*/

using System;
using System.Numerics;


namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                int n = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                int nk = n - k;
                BigInteger factorialN = 1;
                BigInteger factorialK = 1;
                BigInteger factorialNK = 1;

                int countK = 1;
                int countN = 1;
                int countNK = 1;
                while (true)
                {
                    if (countN <= n)
                    {
                        factorialN *= countN;
                        countN++;
                    }

                    if (countK <= k)
                    {
                        factorialK *= countK;
                        countK++;
                    }

                    if (countNK <= nk)
                    {
                        factorialNK *= countNK;
                        countNK++;
                    }

                    if (countN > n && countK > k && countNK>nk)
                    {
                        break;
                    }
                }
                BigInteger result = factorialN / (factorialK*factorialNK);
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
