/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

using System;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                string input = Console.ReadLine();

                string[] numbersStr = input.Split(' ');
                int[] numbers = new int[numbersStr.Length];

                for (int i = 0; i < numbersStr.Length; i++ )
                {
                    numbers[i] = int.Parse(numbersStr[i]);
                }

                int productE = 1;
                int productO = 1;

                for (int j=0; j<numbers.Length; j++)
                {
                    if((j+1)%2!=0)
                    {
                        productO *= numbers[j]; 
                    }
                    else
                    {
                        productE *= numbers[j];
                    }
                }

                if(productE==productO)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
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
