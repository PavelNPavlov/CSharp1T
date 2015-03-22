/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
Examples:

n	x	S
3	2	2.75000
4	3	2.07407
5	-4	0.75781*/

using System;


namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            try
            {
                int n=int.Parse(Console.ReadLine());
                int x=int.Parse(Console.ReadLine());
                double S=1;
                int factorial = 1;
                
                int count=1;
                do
                {
                    factorial *= count;
                    S +=(factorial/Math.Pow((double) x,count));
                    count++;
                }
                while (count <= n);
                decimal output=Convert.ToDecimal(Math.Round(S, 5));
                string format = "0.00000";
                Console.WriteLine(output.ToString(format));

            }

            catch(FormatException)
            {
                Console.WriteLine("Invalid Input format");
            }
            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
