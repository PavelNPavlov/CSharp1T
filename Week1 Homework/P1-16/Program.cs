/*
 Problem 16. Print a Sequence

Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/
using System;


namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int sign = 1; //avoid checks for odd/even member of sequence
            for (int i = 2; i <= 1001; i++) // use <= to use the loop counter directly without any addtional operations. 
            {
                Console.Write(" " + i * sign + " ");
                sign = sign * -1;
                
            }
            Console.WriteLine("\n");
        }
    }
}
