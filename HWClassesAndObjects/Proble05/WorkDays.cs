using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proble05
{
    class WorkDays
    {
        static void Main(string[] args)
        {
           

            DateTime end = DateTime.Parse(Console.ReadLine());

            List<DateTime> publicHollidays = new List<DateTime>();
            // add holidays


            Console.WriteLine(WorkDaysCalc(end, publicHollidays));

        }

        static int WorkDaysCalc(DateTime end, List<DateTime> publicHollidays)
        {
            int count = 0;

            
            // add holidays

             DateTime current = DateTime.Now;

            DateTime start = new DateTime(current.Year, current.Month, current.Day);

            while (start.CompareTo(end)<=0)
            {
                
                if(start.DayOfWeek!=DayOfWeek.Saturday && start.DayOfWeek!=DayOfWeek.Sunday && publicHollidays.Exists(o=> o.Equals(start))==false)
                {
                    count++;
                }
               start=start.AddDays(1);
            }

            return count;
        }
    }
}
