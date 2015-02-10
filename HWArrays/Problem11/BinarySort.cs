/*Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class BinarySort
    {
        static void Main(string[] args)
        {
            Start:
            try
            {

                Console.Write("N: ");
                int N = int.Parse(Console.ReadLine());
               
                
                List<int> array = new List<int>();
                for (int i = 0; i < N; i++)
                {
                    Console.Write(i + ": ");
                    array.Add(int.Parse(Console.ReadLine()));
                }
                array.Sort();

                int v=int.Parse(Console.ReadLine());

                int start=0;
                int end=array.Count;
                int currentV=0;
                
                
                while(true)
                {
                    int tempStart=start;
                    int tempEnd=end;

                    currentV=array[(start+end)/2];
                    if(currentV==v)
                    {
                        Console.WriteLine("{0} = {1} and the index is {2}",currentV,v,(tempStart+tempEnd)/2);
                        break;
                    }
                    if(currentV>v)
                    {
                        end=(tempStart+tempEnd)/2;
                        start=0;
                    }
                    else
                    {
                        end=tempStart+tempEnd;
                        start=(tempStart+tempEnd)/2;
                    }
                }

            }

            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }

            Console.WriteLine("If you wish to continue press [y].");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
