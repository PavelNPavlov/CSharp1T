/*Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader read1 = new StreamReader("TextFile1.txt");
            StringBuilder text = new StringBuilder();
            
            using(read1)
            {
                Console.WriteLine(read1.ReadToEnd());
            }

            read1 = new StreamReader("TextFile1.txt");
            using (read1)
            {
                int count = 0;
                string temp = read1.ReadLine();
                while (temp != null)
                {
                    text.Append((count + 1).ToString()+" " + temp);
                    text.Append(System.Environment.NewLine);
                    temp = read1.ReadLine();
                }
            }

            StreamWriter write = new StreamWriter("Result.txt");

            using(write)
            {
                write.Write(text.ToString());
            }

            StreamReader readResult = new StreamReader("Result.txt");
            
            using(readResult)
            {
                Console.WriteLine(readResult.ReadToEnd());
            }


        }
    }
}
