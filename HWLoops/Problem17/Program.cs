/*Problem 17.* Calculate GCD

Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).*/

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
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                if(b>a)
                {
                    int temp1 = a;
                    a = b;
                    b = temp1;
                }

                int aa = a;
                int bb = b;

                while(true)
                {
                    int temp1 = bb;
                    int temp2 = aa % bb;

                    aa = temp1;
                    bb = temp2;

                    if (temp2 == 0) { break; }


                }

                Console.WriteLine(aa);
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
