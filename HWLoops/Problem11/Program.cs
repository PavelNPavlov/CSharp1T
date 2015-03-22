/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].*/

using System;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                int n = int.Parse(Console.ReadLine());
                int min = int.Parse(Console.ReadLine());
                int max = int.Parse(Console.ReadLine());
                while(min>=max)
                {
                    Console.WriteLine("Realy? Max smaller than Min?");
                    max = int.Parse(Console.ReadLine());
                }

                Random rng = new Random(); //initilize a randomd number generator

                for(int i=0; i<n; i++)
                {
                    Console.Write(rng.Next(min, max)+" "); // Random.Nex(x,y) generates a random whole number between x and y including
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
