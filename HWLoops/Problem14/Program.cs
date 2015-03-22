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
                long number = long.Parse(Console.ReadLine());
                string numberB = "";
                int count = 0;
                while(true)
                {
                    if (number >> 0 == 0)
                    {
                        numberB = "0";
                        break;
                    }
                    else
                    {
                        if(number>>count==0)
                        {
                            break;
                        }
                        long temp = (number >> count) & 1;
                        numberB = temp.ToString() + numberB;
                        if (number >> count == 0) { break; }
                        count++;
                    }
                    

                }

                Console.WriteLine(numberB);
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
