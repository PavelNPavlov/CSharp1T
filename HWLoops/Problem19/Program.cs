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
                int d = int.Parse(Console.ReadLine());
                int[,] numbers = new int[d,d];

                for(int i=0; i<d;i++)
                {
                    for(int j=0; j<d;j++)
                    {
                        numbers[i, j] = -1;
                    }
                }
                int directionx=1;
                int directiony =1;
              
                int x=1;
                int y=0;
                numbers[0, 0] = 1;
                int number = 2;
                int turn=0;
                while(number<=d*d)
                {
                   if(turn==0)
                   {
                       if(x+directionx==d)
                       {
                           turn = 1;
                           directionx *= -1;
                           /*numbers[x, y] = number;
                           number++;*/
                       }
                       else
                       {
                           x += directionx;
                           numbers[x, y] = number;
                           number++;
                       }
                      
                   }

                   else
                   {
                       if (y + directiony == d)
                       {
                           turn = 1;
                           directiony *= -1;
                           /*numbers[x, y] = number;
                           number++;*/
                       }
                       else
                       {
                           y += directiony;
                           numbers[x, y] = number;
                           number++;
                       }
                       
                   }
                }

                for (int i = 0; i < d; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        Console.Write(numbers[i, j]);
                    }
                    Console.WriteLine();
                }

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
