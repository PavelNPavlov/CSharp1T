/*Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = File.ReadAllLines("TextFile1.txt");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Array.Sort(names);

            File.WriteAllLines("Result.txt", names);

            string[] names2 = File.ReadAllLines("Result.txt");

            foreach (var item in names2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
