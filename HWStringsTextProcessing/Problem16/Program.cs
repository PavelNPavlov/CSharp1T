using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateFormat="d.MM.yyyy";
            Console.Write("Enter the firs date: ");
            DateTime d1 = DateTime.ParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture);
            Console.Write("Enter the second date: ");
            DateTime d2 = DateTime.ParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture);

            Console.WriteLine("Distance: {0} days",Period(d1,d2));
        }

        static string Period(DateTime d1, DateTime d2)
        {
            string period = "";
            period = Math.Abs((d1 - d2).TotalDays).ToString();
            return period;
        }
    }
}
