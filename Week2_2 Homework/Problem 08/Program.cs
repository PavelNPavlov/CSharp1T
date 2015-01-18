/*Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).*/
using System;


namespace Problem_08
{
    class Program
    {
        static void Main()
        {
            string run = "y";
            while (run == "y")
            {
                int count = 0; //брояч да провери дали е имало деление
                int number = int.Parse(Console.ReadLine());
                if (number>1)
                {
                    for (int i = 2; i <= 7;i++ ) // 7 е избрано за горен лимит, защото най големия квадрат на просто число от 0-100 е 7х7=49 следващото 11 дава 11х11=121
                    {
                        if (number % i == 0 && i!=number) { count++; }//ако има деление то е преброено
                    }

                    Console.WriteLine(number+" is prime "+(count==0));
                }
                else
                    Console.WriteLine(number + " not a prime");
                Console.WriteLine("If you wish to repeat press y ");
                run = Console.ReadLine();
            }
        }
    }
}
