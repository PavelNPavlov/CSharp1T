using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19
{
    static class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                int N = int.Parse(Console.ReadLine());
                List<int> data=new List<int>();

                for (int i = 1; i <= N; i++)
                {
                    data.Add(i);
                }
                

                foreach (IEnumerable<int> value in pertub)
                {
                    foreach(int a in value)
                    {
                        Console.Write(a + " ");
                    }
                    Console.WriteLine();
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }
        }

        /* public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items)
        {
            if (items.Count() > 1)
            {
                return items.SelectMany(item => GetPermutations(items.Where(i => !i.Equals(item))),
                                       (item, permutation) => new[] { item }.Concat(permutation));
            }
            else
            {
                return new[] { items };
            }
        }*/
    }
}
