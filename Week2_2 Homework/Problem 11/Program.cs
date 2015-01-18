/*Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/
using System;

namespace Problem_11
{
    class Program
    {
        static void Main()
        {
            string run = "y";
            while (run == "y")
            {
                int number = int.Parse(Console.ReadLine());
                int result= number>>3 & 1; //3 позиции надясно, и §1 подсигурява че има само един символ
                Console.WriteLine("For n={0} bit #3= "+ result, number);
                Console.WriteLine("\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }
        }// Повторение на програмата
    }
}
