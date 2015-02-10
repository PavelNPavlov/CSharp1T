/*Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8
{
    class MaxSun
    {
        static void Main(string[] args)
        {
            Start:
            try
            {
            //Console.WriteLine("Enter size of arrays");
                string input = Console.ReadLine();

                string[] inputS = input.Split(',');

                int[] data = new int[inputS.Length];

                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = int.Parse(inputS[i]);
                }
                int sum=0;
                int count=1;
                int countM=-1;
                int sumMax=0;
                int index=0;
                List<int> result = new List<int>();
                for (int i = 1; i < data.Length; i++)
                {
                    if (data[i]+ data[i - 1]>0 )
                    {
                        count++;
                        sum +=data[i-1];

                        if (sum > sumMax)
                        {
                            sumMax=sum;
                            countM=count;
                            index = i; //change the index
                        }
                    }
                    else
                    {
                        count = 1;
                        sum=0;//reset the count
                    }
                }
                Console.WriteLine("C:" + countM);
                index = index + 1 - countM; //flip the result cause otherwise it will go from biggest to smalles
                for (int i = 0; i < countM; i++)
                {
                    result.Add(data[index + i]);//work back from last element in sequence
                }

                if (result[0] < 0) 
                { 
                    result.RemoveAt(0); 
                } //to avoid intial negative number

                foreach (int value in result)
                {
                    Console.Write(value + " ");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }
            Console.WriteLine();
            Console.WriteLine("If you wish to continue press [y].");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}

/*if (result[0] < 0) { result.Remove(0); }

                foreach(int value in result)
                {
                    Console.Write(value + " ");
                }
*/