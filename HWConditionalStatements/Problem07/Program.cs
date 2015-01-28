/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.*/
using System;

namespace Problem07
{
    class Sort
    {
        static void Main()
        {
            double a, b, c;
            double pos1, pos2, pos3;
            Start:
            try
            {

                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());

                pos1 = a;
                pos2 = b;
                pos3 = c;

                if (a >= b && a >= c)
                {
                    pos1 = a;
                    if (b >= c)
                    {
                        pos2 = b;
                        pos3 = c;
                    }
                    else
                    {
                        pos2 = c;
                        pos3 = b;
                    }

                }

                else if (b >= a && b >= c)
                {
                    pos1 = b;
                    if (a >= c)
                    {
                        pos2 = a;
                        pos3 = c;
                    }
                    else
                    {
                        pos2 = c;
                        pos3 = a;
                    }
                }

                else if (c >= a && c >= b)
                {
                    pos1 = c;
                    if (a >= b)
                    {
                        pos2 = a;
                        pos3 = b;
                    }
                    else
                    {
                        pos2 = b;
                        pos3 = a;
                    }
                }

                Console.WriteLine("{0} {1} {2}", pos1, pos2, pos3);
            }

            catch(FormatException)
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
