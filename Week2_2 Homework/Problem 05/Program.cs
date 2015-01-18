/*Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.*/

using System;


namespace Problem_05
{
    class Program
    {
        static void Main()
        {
            string run = "y";
            while (run == "y")
            {
                Console.WriteLine("Input integer");

                //version 1 string solution
                Console.WriteLine("String Solution");
                string numberString = Console.ReadLine();
                bool isThrid7;
                if (numberString.Length >= 3)
                {
                    isThrid7 = (numberString[numberString.Length-3] == '7' && numberString.Length >= 3);
                }
                else
                    isThrid7 = false;
                Console.WriteLine("Does the number {0} has seven as its tird digit from the right? " + isThrid7, numberString);
                //version 2 number solution
                Console.WriteLine("Integer Solution");
                int numberInt = int.Parse(Console.ReadLine());
                bool isThrid7_2=((numberInt%1000)/100==7);
                Console.WriteLine("Does the number {0} has seven as its tird digit from the right? " + isThrid7_2, numberInt);
                Console.WriteLine("\n\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }
        }
    }
}
