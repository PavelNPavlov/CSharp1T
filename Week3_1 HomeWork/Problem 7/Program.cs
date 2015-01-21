using System;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
            Input://Label, can be used with goto comand
                string[] input = Console.ReadLine().Split();
            Process:
                double sum = 0;
                foreach(string value in input)
                {
                    sum = sum + double.Parse(value);
                }



            Output:
                Console.WriteLine(sum);
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
