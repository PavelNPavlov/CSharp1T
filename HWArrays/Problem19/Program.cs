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
                

                for(int i=0; i<data.Count; i++)
                {

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
