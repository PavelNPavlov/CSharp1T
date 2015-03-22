/*Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader read1 = new StreamReader("TextFile1.txt");
            List<string> textFile1 = new List<string>();

            using (read1)
            {
                Console.WriteLine(read1.ReadToEnd());
            }
            Console.WriteLine();
            using(StreamReader readtemp=new StreamReader ("TextFile2.txt"))
            {
                Console.WriteLine(readtemp.ReadToEnd());
            }
            Console.WriteLine();
            read1 = new StreamReader("TextFile1.txt");
            using (read1)
            {
                string temp = read1.ReadLine();
                while (temp != null)
                {
                    textFile1.Add(temp);
                    temp = read1.ReadLine();
                }
            }

            StreamReader read2 = new StreamReader("TextFile2.txt");
            bool equal = false;
            using(read2)
            {
                int count = 0;
                string temp = read2.ReadLine();
                while (temp != null)
                {
                    if(temp!=textFile1[count])
                    {

                        equal = true;
                        break;
                        
                    }
                    temp = read2.ReadLine();
                }
            }

            Console.WriteLine("File are different? {0}",equal);
        }
    }
}
