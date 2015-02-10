using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0; //student count
            int S = 0; //number of paper
            double P = 0; //prices of stakc 400 sheet per stack

            N = int.Parse(Console.ReadLine());
            S = int.Parse(Console.ReadLine());
            P = double.Parse(Console.ReadLine());
            P = Math.Round(P, 3);
            double  ts = N * S;
            ts = Math.Round(ts,3);
            double tm = (ts / 400.000) * P;

            Console.WriteLine(tm.ToString("#.000"));
        }
    }
}
