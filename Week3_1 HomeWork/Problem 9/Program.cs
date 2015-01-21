using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
            Input://Label, can be used with goto comand
                int numberInSequence = int.Parse(Console.ReadLine());

            Process:
                double sum = 0;
                for (int i = 1; i <= numberInSequence; i++)
                {
                    sum = sum + double.Parse(Console.ReadLine());
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
