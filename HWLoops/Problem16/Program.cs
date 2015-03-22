/*Problem 16. Decimal to Hexadecimal Number

Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
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
                long number = long.Parse(Console.ReadLine());
                string numberB = "";
                while (true)
                {
                    long tempS = number % 16;
                    switch (tempS)
                    {
                        case 0:
                            numberB = "0" + numberB;
                            break;
                        case 1:
                            numberB = "1"+ numberB;;
                            break;
                        case 2:
                            numberB = "2"+ numberB;;
                            break;
                        case 3:
                            numberB = "3"+ numberB;;
                            break;
                        case 4:
                            numberB = "4"+ numberB;;
                            break;
                        case 5:
                            numberB = "5"+ numberB;;
                            break;
                        case 6:
                            numberB = "6"+ numberB;;
                            break;
                        case 7:
                            numberB = "7"+ numberB;;
                            break;
                        case 8:
                            numberB = "8"+ numberB;;
                            break;
                        case 9:
                            numberB = "9"+ numberB;;
                            break;
                        case 10:
                            numberB = "A"+ numberB;;
                            break;
                        case 11:
                            numberB = "B"+ numberB;;
                            break;
                        case 12:
                            numberB = "C"+ numberB;;
                            break;
                        case 13:
                            numberB = "D"+ numberB;;
                            break;
                        case 14:
                            numberB = "E"+ numberB;;
                            break;
                        case 15:
                            numberB = "F"+ numberB;;
                            break;
                        default:
                            break;
                    }
                    number /= 16;
                    if (number == 0) { break; }
                }

                Console.WriteLine(numberB);
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
