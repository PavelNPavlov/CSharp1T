/*Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            
            StreamReader read1 = new StreamReader("TextFile1.txt");
            StreamReader read2 = new StreamReader("TextFile2.txt");
            StreamWriter write = new StreamWriter("EndResult.txt");
            using (read1)
            {
                text.Append(read1.ReadToEnd());
            }
            text.Append(System.Environment.NewLine);
            using (read2)
            {
                text.Append(read2.ReadToEnd());
            }
            using(write)
            {
                write.Write(text.ToString());
            }

            StreamReader read3 = new StreamReader("EndResult.txt");

            using(read3)
            {
                Console.WriteLine(read3.ReadToEnd());
            }
        }
    }
}
