/*Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class SumSeq
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                //Console.WriteLine("Enter size of arrays");
                string input = Console.ReadLine();

                string[] inputS = input.Split(',');

                int[] data = new int[inputS.Length];

                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = int.Parse(inputS[i]);
                }
                int sum = int.Parse(Console.ReadLine());

                int cSum = 0;
                int lastIndex = 0;
                int count=0;
                for (int i = 1; i < data.Length; i++)
                {
                    cSum = data[i];
                    lastIndex = i;
                    count = i + 1;
                    while(cSum<sum)
                    {
                        cSum += data[count];
                        if (cSum >= sum) { break; }
                        else { count++; }
                    }
                    if (cSum == sum) { break; }
                }

                Console.WriteLine(cSum);

                for (int i = lastIndex; i <= count;i++ )
                {
                    Console.Write(data[i] + ", ");                
                }
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
