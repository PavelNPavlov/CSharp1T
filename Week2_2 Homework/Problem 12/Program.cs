/*Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.*/

using System;


namespace Problem_12
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
                Console.WriteLine("Bit #{0} of the number {1} is: " + result, position, number);
                Console.WriteLine("\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }// Повторение на програмата
        }
    }
}
