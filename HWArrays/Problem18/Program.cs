using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
             Start:
            try
            {
                //Console.WriteLine("Enter size of arrays");
                string input = Console.ReadLine();

                string[] inputS = input.Split(',');

                List<int> data=new List<int>();

                for (int i = 0; i < inputS.Length; i++)
                {
                    data.Add(int.Parse(inputS[i]));
                }
                List<int> data2 = new List<int>();
                int count = 0;
                for(int i=1; i<data.Count-1;i++)
                {
                    if(count==0)
                    {
                        if(data[i]<data[i-1])
                        {
                            data.RemoveAt(i - 1);
                            count++;
                        }
                    }
                    else
                    {
                        if( data[i-1]>=data[i-2] && data[i-1]<=data[i] )
                        {
                            count++;
                        }
                        else
                        {
                            data.RemoveAt(i-1);
                        }
                    }
                }

                foreach(int value in data)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();

                
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }

            Console.WriteLine("If you wish to continue press [y].");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
