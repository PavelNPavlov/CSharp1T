using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            int[,] matrix;
            StreamReader readFile = new StreamReader("TextFile1.txt");

            using(readFile)
            {
                size = int.Parse(readFile.ReadLine());
                matrix = new int[size, size];
                int count=0;
                string temp="";
                
                while (true)
                {
                    temp = readFile.ReadLine();
                    
                    if(temp==null)
                    { break; }

                    string[] content = temp.Split(' ');

                    for (int i = 0; i < size; i++)
                    {
                        matrix[count,i] = int.Parse(content[i]);
                    }
                    count++;
                    
                }
                
                int max=matrix[0,0]+matrix[1,0]+matrix[1,1]+matrix[0,1];
                for (int i = 1; i < size-1; i++)
                {
                    for (int j = 0; j < size-1; j++)
                    {
                        int tempsum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                        if(tempsum>max)
                        {
                            max = tempsum;
                        }
                    }
                }

                Console.WriteLine(max);
            }
        }
    }
}
