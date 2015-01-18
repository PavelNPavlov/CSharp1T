using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {
             string run = "y";
            while (run == "y")
            {
                Console.WriteLine("Input integer");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Input position");
                int position = int.Parse(Console.ReadLine());
                Console.WriteLine("Input bit value");
                int bitvalue = int.Parse(Console.ReadLine());


                int result = (number>>position)&1 ^ bitvalue;
                result = number ^ (result << position); // смяна на стойността на определен бит
                Console.WriteLine(result);
                //Console.WriteLine("Is bit #{0} of the number {1} 1?\n" + (result == 1), position, number);
                Console.WriteLine("\nIf you wish to repeat press y ");
                run = Console.ReadLine();
            }
        }
        
    }
}
