/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/
using System;


namespace Problem09
{
    class PlayType
    {
        static void Main()
        {
        Start:
            try
            {
                Console.WriteLine("Chose input type: (int/double/string)");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "int":
                        int inputi = int.Parse(Console.ReadLine());
                        Console.WriteLine(inputi + 1);
                        break;
                    case "double":
                        double inputd = double.Parse(Console.ReadLine());
                        Console.WriteLine(inputd + 1);
                        break;

                    case "string":
                        Console.WriteLine(Console.ReadLine()+"*");
                        break;
                    default:
                        Console.WriteLine("Invalide Choice");
                        break;
                }
            }

            catch(FormatException)
            {
                Console.WriteLine("Chosen datatype doesn't correspod to input");
            }

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
