/*Problem 4. Print a Deck of 52 Cards

Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.*/
using System;

namespace Problem04
{
    class Cards
    {
        static void Main(string[] args)
        {
            Start:
            try
            {
                string[] database1=new string[]
                {
                    "2","3","4", "5", "6", "7","8","9","10","J","Q","K","A"
                };

                string[] database2=new string[]
                {
                    " of clubs,"," of dimonds,"," of hearts,", " of spades"
                };

                for(int i=0; i<database1.Length; i++)
                {
                    for(int j=0; j<database2.Length; j++)
                    {
                        Console.Write(" "+database1[i]+database2[j]);
                    }
                    Console.Write("\n");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid Input format");
            }
            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
