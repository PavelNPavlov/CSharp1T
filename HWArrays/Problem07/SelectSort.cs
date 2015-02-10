/*Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.*/
using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem07
{
    class SelectSort
    {
        static void Main(string[] args)
        {
        Start:
            try
            {

                Console.Write("N: ");
                int N = int.Parse(Console.ReadLine());
               
                
                List<int> arrayUns = new List<int>();
                List<int> arrayS = new List<int>();
                for (int i = 0; i < N; i++)
                {
                    Console.Write(i + ": ");
                    arrayUns.Add(int.Parse(Console.ReadLine()));
                }

                while(true)
                {

                    arrayS.Add(arrayUns.Min());
                    arrayUns.Remove(arrayUns.Min());
                    if (arrayUns.Count == 0) { break; }
                }

                foreach(int value in arrayS)
                {
                    Console.Write(value + " ");
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
