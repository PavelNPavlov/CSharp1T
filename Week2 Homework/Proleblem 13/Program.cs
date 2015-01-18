using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.*/
namespace Proleblem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string keeprunning="y";
            while (keeprunning == "y") // Поради естеството на тестване прогрмата ще се повтори до въвеждане на друг знак освен y
            {
                double eps = 0.000001;
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                bool isequal = Math.Abs(num1 - num2) < eps;
                Console.WriteLine(isequal);
                Console.WriteLine(Math.Abs(num1 - num2));
                Console.WriteLine(eps);
                Console.WriteLine("If you whish to do it again press   y   ");
                keeprunning = Console.ReadLine();
            }

        }
    }
}
