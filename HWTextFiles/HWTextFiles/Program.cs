/*Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader("TextFile1.txt");
            int count = 0;
            using(read)
            {
                string temp = read.ReadLine();
                while(temp!=null)
                {
                    if(count%2!=0)
                    {
                        Console.WriteLine(temp);
                    }
                    count++;
                    temp = read.ReadLine();
                }
            }
        }
    }
}
