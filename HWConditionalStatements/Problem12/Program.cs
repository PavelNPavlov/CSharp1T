/*Problem 12.* Zero Subset

We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.*/


//Subests that are duplicates could be removed, with a check on bothe the string and sum list, but again couldn't be bother. The check will look for the same sum and the same number of elemts. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Program
    {
        static void Main()
        {
            int[] input = new int[5];
            List<int> positive = new List<int>(); //list since number is unknown
            List<int> negative = new List<int>();
            List<int> zero= new List<int>();
            Start:
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    int temp = int.Parse(Console.ReadLine()); //should be skipped but couldn't be bothered
                    input[i] = temp;
                    if (temp > 0) { positive.Add(temp); }
                    if (temp < 0) { negative.Add(temp); }
                    if (temp == 0) { zero.Add(temp); }
                }

                List<string> positiveSub = new List<string>(); //list for all possible subsets
                List<string> negativeSub = new List<string>(); // use string since it is easier to record all member of a subset alternatively list of int array could be used

                if (positive.Count == 1) { positiveSub.Add(positive[0].ToString()); } //handle list of 1
                if (positive.Count > 1)
                {
                    for (int i = 1; i < positive.Count; i++)
                    {
                        positiveSub.Add(positive[i - 1].ToString());

                        List<string> newSubsets = new List<string>();

                        // Loop over existing subsets
                        for (int j = 0; j < positiveSub.Count; j++)
                        {
                            string newSubset = positiveSub[j] + "+" + positive[i]; //add the + for easier output
                            newSubsets.Add(newSubset);
                        }

                        positiveSub.AddRange(newSubsets);
                    }//all subsets beside last member of list

                    positiveSub.Add(positive[positive.Count - 1].ToString()); //last member of list
                }


                if (negative.Count == 1) { negativeSub.Add(negative[0].ToString()); }
                if (negative.Count > 1)
                {
                    for (int i = 1; i < negative.Count; i++)
                    {
                        negativeSub.Add(negative[i - 1].ToString());

                        List<string> newSubsets = new List<string>();

                        // Loop over existing subsets
                        for (int j = 0; j < negativeSub.Count; j++)
                        {
                            string newSubset = negativeSub[j] + "+" + negative[i];
                            newSubsets.Add(newSubset);
                        }

                        negativeSub.AddRange(newSubsets);
                    }
                    negativeSub.Add(negative[negative.Count - 1].ToString());
                }

                List<int> sumsPositive = new List<int>(); //list of sums of each subset for comparison
                List<int> sumsnegative = new List<int>();


                foreach (string value in positiveSub)
                {
                    //Console.Write(value); //for printing all subsets
                    int sum = 0;
                    string[] temp = value.Split('+'); //get an array for each subset string
                    foreach (string number in temp)
                    {
                        sum += int.Parse(number); // parse and added to a sum
                    }
                    sumsPositive.Add(sum);

                    //Console.Write("     " + sum + "\n"); //for seperating subsets by lines
                }

                foreach (string value in negativeSub)
                {
                    //Console.Write(value);
                    int sum = 0;
                    string[] temp = value.Split('+');
                    foreach (string number in temp)
                    {
                        sum += int.Parse(number);
                    }
                    sumsnegative.Add(sum);

                    //Console.Write("     " + sum + "\n");
                }
                int counter = 0;
                for (int i = 0; i < sumsPositive.Count; i++)
                {
                    for (int j = 0; j < sumsnegative.Count; j++)
                    {
                        if (sumsPositive[i] == -sumsnegative[j])
                        {
                            Console.WriteLine(positiveSub[i] + " + (" + negativeSub[j] + ") =0");
                            counter++;
                        }

                    }
                } //Printing subsets

                if (zero.Count > 0)
                {
                    string outputzero;
                    for (int i = 0; i < zero.Count; i++)
                    {
                        if (i == 0) { Console.Write("0 "); }
                        else { Console.Write(" + 0"); }
                    }
                    Console.Write("=0\n");
                }

                if ((zero.Count == 0 && (positive.Count == 0 || negative.Count == 0)) || counter == 0)
                {
                    Console.WriteLine("No zero subsets");
                }//if you want to get a meesage for no subsets\
            }

            catch(FormatException)
            {
                Console.WriteLine("Invalide input type/types");
            }

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
