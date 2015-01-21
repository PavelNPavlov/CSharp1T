/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

using System;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            try
            {
            Input://Label, can be used with goto comand
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
            Process:
                double D= Math.Pow(b,2) - 4*a*c;
                if(D<0){Console.WriteLine("No real roots"); goto RunAgain;}
                double x1=(-b + Math.Sqrt(D))/(2*a);
                double x2=(-b - Math.Sqrt(D))/(2*a);
            Output:
                Console.WriteLine("x1={0} x2={1}",x1,x2);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please try Again!");
                goto Start;
            }

            RunAgain:
            Console.WriteLine("If you wish to run the program again press y");
            if (Console.ReadLine() == "y") { goto Start; }
        }
        
    }
}
