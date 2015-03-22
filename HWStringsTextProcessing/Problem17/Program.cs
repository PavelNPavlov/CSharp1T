using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = new System.Globalization.CultureInfo("bg-BG");
           
            string dateFormat = "d.MM.yyyy h:m:s";
            Console.Write("Enter the firs date: ");
            DateTime d1 = DateTime.ParseExact(Console.ReadLine(), dateFormat,culture);
            Console.WriteLine("{0}",ChangeTime(d1),dateFormat, culture);
            var day = culture.DateTimeFormat.GetDayName(ChangeTime(d1).DayOfWeek);
            Console.WriteLine(day);
        }

        static DateTime ChangeTime(DateTime d)
        {
            return d.AddHours(6).AddMinutes(30);
        }
    }
}
