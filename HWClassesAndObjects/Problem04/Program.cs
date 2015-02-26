using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static double TriangleArea(double s, double alt)
        {
            double area = 0;

            if(s<=0 || alt<=0)
            {
                Console.WriteLine("Common sides or altitued need to be greater than zero!!!");
                return area;
            }

            area = s * alt / 2;
            return area;
        }

        static double TriangleArea(double s1, double s2, double s3)
        {
            double area = 0;
            if (s1 <= 0 || s2 <= 0 || s3<=0)
            {
                Console.WriteLine("Common sides or altitued need to be greater than zero!!!");
                return area;
            }

            double p = (s1 + s2 + s3) / 2;

            area = Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
            return area;
        }

        static double TriangleArea(double s1, double s2, double a)
        {
            double area = 0;
            if (s1 <= 0 || s2 <= 0)
            {
                Console.WriteLine("Common sides or altitued need to be greater than zero!!!");
                return area;
            }

            area = s1 * s2 * Math.Sin(a) / 2;
            return area;
        }
    }
}
