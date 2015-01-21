/*oblem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.*/
using System;


namespace Problem_11
{
    class Interval
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
            Input://Label, can be used with goto comand
                int border1 = int.Parse(Console.ReadLine());
                int border2 = int.Parse(Console.ReadLine());

            Process:
                int begin; int end;
                if (border1 > border2) { begin = border2; end=border1; }
                else { begin = border1; end = border2; }
                int count=0;
                for (int i=begin; i<=end; i++)
                {
                    if(i%5==0){ count++;}
                }


            Output:
                Console.WriteLine(count);

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
