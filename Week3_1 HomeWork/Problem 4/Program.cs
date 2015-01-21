/*Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/
using System;


namespace Problem_4
{
    class Program
    {
        static void Main()
        {
        Start:
            try
            {
            Input:
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
            Process:
                int aFactor=Convert.ToInt32(a>=b); //Make sure a=b case is included as well
                int bFactor=Convert.ToInt32(b>a);
                //Give a factor depending on condition 1 for true, 0 for false
            Output:
                Console.WriteLine(a*aFactor+b*bFactor);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please try Again!");
                goto Start;
            }
            Console.WriteLine("If you wish to run the program again press y");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
