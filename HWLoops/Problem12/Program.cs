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
                int n = int.Parse(Console.ReadLine());
                List<int> numbers = new List<int>();

                Random rng = new Random(); //initilize a randomd number generator

                for (int i = 0; i < n; i++)
                {
                    if(i==0)
                    {
                        numbers.Add(rng.Next(1,n+1));
                    } //add the first number
                    else
                    {
                        int exit = 1;
                        while (exit==1)
                        {
                            int temp = rng.Next(1, n+1);
                            int count = 0;
                            foreach (int value in numbers)
                            {
                                if (temp == value) { count++; }
                            }
                            if (count == 0)
                            {
                                numbers.Add(temp);
                                exit = 0;
                            }
                        }//checks if the newly generated rng is contained, if not it breaks
                    }
                }
                
                foreach(int value in numbers)
                {
                    Console.Write(value + " ");
                }
                Console.Write("\n");
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
