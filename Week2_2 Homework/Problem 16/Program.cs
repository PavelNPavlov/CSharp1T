/*Problem 16.** Bit Exchange (Advanced)

Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.*/

using System;

namespace Problem_16
{
    class Program
    {
        static void Main(string[] args)
        {

            string run = "y";
            while (run == "y")
            {
                Console.WriteLine("Input integer");
                string z = Console.ReadLine();
                uint j;
                if (UInt32.TryParse(z, out j) == false) { goto OutOfRange; }
                uint number = uint.Parse(Console.ReadLine());

                Console.WriteLine("Input p");
                int p = int.Parse(Console.ReadLine());
                Console.WriteLine("Input q");
                int q = int.Parse(Console.ReadLine());
                Console.WriteLine("Input k");
                int k = int.Parse(Console.ReadLine());

                if ((p > q && q + k >= p) || (q > p && p + k >= q)) {goto OverLaping; } // goto Отива директно на labela от формат xxxxx: и кода продължава от там.
                if (q + k >= 32 || p + k >= 32 || p < 0 || q < 0)  { goto OutOfRange; }
                
                uint select=0;
                
                for(int i=0;i<k;i++)
                {
                    select=select + (uint)Math.Pow(2,i);
                } //изчислява числото за селекция на поредицата може със ConverTo(....,2)
                //повторения на предисхната задача
                uint bitsSequenceLow = (number >> p) & select;
                uint bitsSequenceHigh = (number >> q) & select;
                //uint bitsSequenceTemp = bitsSequenceHigh;
                uint result;
                result = (number >> p) & select ^ bitsSequenceHigh;
                result = number ^ (result << p);
                uint temp = result;
                result = (temp >> q) & select ^ bitsSequenceLow;
                result = (temp ^ (result << q));

                Console.WriteLine(result);
                goto Repeat; //Пропуска предупрежденията за грешен формат
                
                OutOfRange:
                    Console.WriteLine("Out of range");
                    goto Repeat; // да пропусне изписването на OverLapp
                OverLaping:
                    Console.WriteLine("Overlapp");

                Repeat:
                //Console.WriteLine("Is bit #{0} of the number {1} 1?\n" + (result == 1), position, number);
                Console.WriteLine("\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }// Повторение на програмата
        }
    }
}
