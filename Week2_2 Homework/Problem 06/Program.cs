/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/
using System;


namespace Problem_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string run = "y";
            while (run == "y")
            {
                Console.WriteLine("Input a four diggit number: ");
                string input = Console.ReadLine();
                while (input.Length!=4 && input[0]!='0')
                {
                    Console.WriteLine("Invalid entry, pleas try again");
                    input = Console.ReadLine();
                }
                int numberInput = int.Parse(input);
                int a = numberInput / 1000;
                int b = numberInput%1000/100;
                int c = numberInput%100/10;
                int d = numberInput%10;
                if (d != 0)
                {
                    int digitSum = a + b + c + d;
                    int reverse = d * 1000 + c * 100 + b * 10 + a;
                    int lastDigitFron = d * 1000 + a * 100 + b * 10 + c;
                    int exchange23 = a * 1000 + d + c * 100 + b * 10;
                    Console.WriteLine("{0}  {1}  {2}  {3}  {4}", numberInput, digitSum,reverse, lastDigitFron, exchange23);

                }
                else 
                {
                    Console.WriteLine("Number edns ends with 0");
                }

                Console.WriteLine("\n\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }
        }
    }
}
