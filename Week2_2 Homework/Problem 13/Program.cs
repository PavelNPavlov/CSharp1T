/*Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.*/
using System;
using System;

namespace Problem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string run = "y";
            while (run == "y")
            {
                Console.WriteLine("Input integer");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Input position");
                int position = int.Parse(Console.ReadLine());


                int result = number >> position & 1;
                Console.WriteLine("Is bit #{0} of the number {1} 1?\n" + (result == 1), position, number);
                Console.WriteLine("\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }// Повторение на програмата
        }
    }
}
