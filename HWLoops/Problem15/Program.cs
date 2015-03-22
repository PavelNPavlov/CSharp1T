/*Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

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
                string input = Console.ReadLine();
                long output = 0;

                for (int i = 0; i < input.Length; i++ )
                {
                    char temp = input[input.Length-1-i];
                    long temp1= 0;
                    switch (temp)
                    {
                        case '0':
                            temp1 = 0;
                            break;
                        case '1':
                            temp1 = 1;
                            break;
                        case '2':
                            temp1 = 2;
                            break;
                        case '3':
                            temp1 = 3;
                            break;
                        case '4':
                            temp1 = 4;
                            break;
                        case '5':
                            temp1 = 5;
                            break;
                        case '6':
                            temp1 = 6;
                            break;
                        case '7':
                            temp1 = 7;
                            break;
                        case '8':
                            temp1 = 8;
                            break;
                        case '9':
                            temp1 = 9;
                            break;
                        case 'A':
                            temp1 = 10;
                            break;
                        case 'B':
                            temp1 = 11;
                            break;
                        case 'C':
                            temp1 = 12;
                            break;
                        case 'D':
                            temp1 = 13;
                            break;
                        case 'E':
                            temp1 = 14;
                            break;
                        case 'F':
                            temp1 = 15;
                            break;
                        default:
                            break;

                    }

                    output += temp1 * (long)Math.Pow(16, i);

                }
                Console.WriteLine(output);
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
