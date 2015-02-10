/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.*/
using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem06
{
    class MaxSumSeq
    {
        static void Main(string[] args)
        {
        Start:
            try
            {

                Console.Write("N: ");
                int N = int.Parse(Console.ReadLine());
                Console.Write("K: ");
                int K = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int sum = 0;
                List<int> array1= new List<int>();
                for (int i = 0; i < N; i++)
                {
                    Console.Write(i + ": ");
                    array1.Add(int.Parse(Console.ReadLine()));
                }

                for (int i = 0; i < K; i++ )
                {
                    int maxTemp = array1.Max();
                    sum += maxTemp;
                    int maxTempIndex = array1.IndexOf(maxTemp); //get the index of the max value
                    array1.RemoveAt(maxTempIndex); //remove it so the next max will the next maxumum
                }

                Console.WriteLine(sum);
            }

            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }

            Console.WriteLine("If you wish to continue press [y].");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
