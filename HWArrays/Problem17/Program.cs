/*Problem 16.* Subset with sum S

We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the array that has a sum S.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                Console.WriteLine("Enter size of arrays");
                int N = int.Parse(Console.ReadLine());
                /*string input = Console.ReadLine();

                string[] inputS = input.Split(',');*/

                List<int> data = new List<int>();

                for (int i = 0; i < N; i++)
                {
                    data.Add(int.Parse(Console.ReadLine()));
                }

                List<string> combinations = new List<string>();

                combinations = AllSubsets(data);

                List<List<int>> numCombinations = new List<List<int>>();
                List<int> sums = new List<int>();

                foreach (string value in combinations)
                {
                    List<int> temp = new List<int>();
                    string[] s = value.Split(' ');

                    foreach (string a in s)
                    {
                        temp.Add(int.Parse(a));
                    }
                    numCombinations.Add(temp);
                    sums.Add(temp.Sum());
                }
                Console.WriteLine("Input Sum");
                int S = int.Parse(Console.ReadLine());

                Console.WriteLine("Size of Subset");
                int K = int.Parse(Console.ReadLine());
                int count = 0;
                for (int i = 0; i < sums.Count; i++)
                {
                    if (sums[i] == S && numCombinations[i].Count==K)
                    {
                        foreach(int value in numCombinations[i])
                        {
                            Console.Write(value + " ");
                        }
                        Console.WriteLine();
                        break;
                        count++;
                    }
                }

                if(count==0)
                {
                    Console.WriteLine("No such subsets");
                }

            }

            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }

            Console.WriteLine("If you wish to continue press [y].");
            if (Console.ReadLine() == "y") { goto Start; }
        }

        public static List<string> AllSubsets(List<int> input)
        {
            List<string> subsets = new List<string>();

            // Loop over individual elements
            for (int i = 1; i < input.Count; i++)
            {
                subsets.Add(input[i - 1].ToString());

                List<string> newSubsets = new List<string>();

                // Loop over existing subsets
                for (int j = 0; j < subsets.Count; j++)
                {
                    string newSubset = subsets[j] + " " + input[i];
                    newSubsets.Add(newSubset);
                }

                subsets.AddRange(newSubsets);
            }

            // Add in the last element
            subsets.Add(input[input.Count - 1].ToString());

            return subsets;
        }

    }
}
