using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWClassesAndObjects
{
    class IsLeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Is {0} a leap year? {1}",year,DateTime.IsLeapYear(year));
        }
    }
}
