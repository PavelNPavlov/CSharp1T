/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.*/

using System;


namespace Problem_03
{
    class Program
    {
        static void Main()
        {
            string run = "y";
            while (run == "y")
            {
                int number = int.Parse(Console.ReadLine());
                bool isDivisable75 = (number % 35 == 0 && number!=0); // за да се дели и на 7 и на 5 може да се направи проверка за 35
                Console.WriteLine("Is {0}, divisable by both 7 and 5? " + isDivisable75,number);
                Console.WriteLine("\n\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }// Повторение на програмата
        }
    }
}
