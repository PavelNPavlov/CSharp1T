/*Problem 11.* Number as Words

Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.*/

using System;

namespace Problem08
{
    class Program
    {
        static void Main()
        {
            string[] database1 = new string[]
            {
                "one","two","three","four","five",
                "six","seven","eight","nine","ten",
                "eleven","twelve","thirteen","fourteen","fifteen",
                "sixteen","seventeen","eighteen","nineteen"
                    
            };

            string[] database2 = new string[]
            {
                " twen"," thir"," four"," fif"," six"," seven"," eight"," nine",   
            };
            Start:
            try
            {
                int input = int.Parse(Console.ReadLine());

                if (input < 1000)
                {
                    if (input > 100)
                    {
                        Console.Write(database1[(input / 100) - 1] + "hundred and");

                        if ((input % 100 / 10) < 2)
                        {
                            Console.Write(" " + database1[(input % 100) - 1]);
                        }
                        else
                        {
                            Console.Write(database2[(input % 100 / 10) - 2] + "ty ");
                            if (input % 10 != 0)
                            {
                                Console.Write(database1[(input % 10) - 1]);
                            }
                        }
                        Console.Write("\n");
                    }

                    else
                    {
                        if ((input % 100 / 10) < 2)
                        {
                            Console.Write(database1[(input % 100) - 1]);
                        }
                        else
                        {
                            Console.Write(database2[(input % 100 / 10) - 2] + "ty ");
                            if (input % 10 != 0)
                            {
                                Console.Write(" " + database1[(input % 10) - 1]);
                            }
                        }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }

            catch(FormatException)
            {
                Console.WriteLine("Invalid input format");
            }

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }

        }
    }
}
