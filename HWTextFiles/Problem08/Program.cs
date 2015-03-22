using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
       
            ReplaceFile("TextFile1.txt", "Result.txt");

            string[] r1 = File.ReadAllLines("TextFile1.txt");

            foreach (var item in r1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            string[] r = File.ReadAllLines("Result.txt");

            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
        }


        static void ReplaceFile(string FilePath, string NewFilePath)
        {
            using (StreamReader vReader = new StreamReader(FilePath))
            {
                using (StreamWriter vWriter = new StreamWriter(NewFilePath))
                {
                    int vLineNumber = 0;
                    while (!vReader.EndOfStream)
                    {
                        string vLine = vReader.ReadLine();
                        vWriter.WriteLine(ReplaceLine(vLine, vLineNumber++));
                    }
                }
            }
        }


       
        static string ReplaceLine(string Line, int LineNumber)
        {
            Line = Line.Replace(" star ", " end ");
            Line = Line.Replace(" star, ", " end, ");
            Line = Line.Replace(" star. ", " end. ");
            Line = Line.Replace(" star! ", " end! ");
            Line = Line.Replace(" star? ", " end? ");
            return Line;
        }
    }
    
}
