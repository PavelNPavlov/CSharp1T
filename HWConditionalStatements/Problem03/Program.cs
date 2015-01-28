/*Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:*/
using System;
using System.Collections.Generic;

namespace Problem03
{
    class Program
    {
        static void Main()
        {
            List<string> cardTypes = new List<string>();
            cardTypes.Add("2");
            cardTypes.Add("3");
            cardTypes.Add("4");
            cardTypes.Add("5");
            cardTypes.Add("6");
            cardTypes.Add("7");
            cardTypes.Add("8");
            cardTypes.Add("9");
            cardTypes.Add("10");
            cardTypes.Add("J");
            cardTypes.Add("Q");
            cardTypes.Add("K");
            cardTypes.Add("A");
        
            Start:

            string input = Console.ReadLine();
            if(cardTypes.Exists(x => x==input))
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }

        }
    }
}
