/*Problem 10.* Beer Time

A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.*/
using System;
using System.Globalization;

namespace Problem10
{
    class Beer
    {
        static void Main(string[] args)
        {
            
            DateTime input;
            string format="hh:mm tt";
            Start:
            try
            {
                CultureInfo provider = CultureInfo.InvariantCulture;
                Console.WriteLine(" Input time in format hh:mm tt");
                input = DateTime.ParseExact(Console.ReadLine(), format, provider);
                //string ampm=input.ToString("tt");
                //if ((input.Hour >= 1 && ampm == "PM") || (input.Hour <= 2 && ampm == "AM")) alternative version that goes with format
                if (input.Hour>=13 || input.Hour<3) //despite format being with am pm the hourst are still kept as 0-24
                {
                    Console.WriteLine("BEER Time");
                }

                else
                {
                    Console.WriteLine("Not beer time, but are you kidding you are dringking anyway");
                }
            }
            
            catch(FormatException)
            {
                Console.WriteLine("Invalid Date");
            }

            Console.WriteLine("Press [y] to repeat.");
            if (Console.ReadLine() == "y") { goto Start; }

        }
    }
}
