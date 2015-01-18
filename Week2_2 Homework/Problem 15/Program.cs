/*Problem 16.** Bit Exchange (Advanced)

Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.*/
using System;

namespace Problem_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string run = "y";
            while (run == "y")
            {
                Console.WriteLine("Input integer");
                uint number = uint.Parse(Console.ReadLine());
                //Console.WriteLine("Input position");
                //int position = int.Parse(Console.ReadLine());
                //Console.WriteLine("Input bit value");
                //int bitvalue = int.Parse(Console.ReadLine());

                uint bitsSequenceLow = (number >> 3) & 7; //взимане на поредицата от 3 бита 7(10)=111(2)
                uint bitsSequenceHigh = (number >> 24) & 7;
                uint result;
                result = (number >> 3) & 7 ^ bitsSequenceHigh;
                result = number ^ (result << 3); //първа промяна
                uint temp = result;// ненужно но добро за проверка
                result = (temp >> 24) & 7 ^ bitsSequenceLow;
                result = (temp ^ (result << 24)); //втора промяна


                
                Console.WriteLine(result);
                //Console.WriteLine("Is bit #{0} of the number {1} 1?\n" + (result == 1), position, number);
                Console.WriteLine("\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }
        }
    }
}
