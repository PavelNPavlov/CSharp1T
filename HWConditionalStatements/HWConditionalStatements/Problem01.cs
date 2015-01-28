/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.*/

using System;

namespace Problem01
{
    class Swap
    {
        static void Main()
        {
            Start:
            double a, b, temp=0; 
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            if(a>b)
            {
                temp=a;
                a = b;
                b = temp;
            }

            Console.WriteLine("{0} {1}", a, b);

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
