using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string run = "y";
            while (run == "y")
            {
                Console.Write("Input x coordinate: ");
                double xpoint = double.Parse(Console.ReadLine());
                Console.Write("Input y coordinate: ");
                double ypoint = double.Parse(Console.ReadLine());
                //Проверка за извън кръга
                double xcenter = 1;
                double ycenter = 1;
                double rcircle = 1.5;
                double xdistance = Math.Abs(xcenter - xpoint);
                double ydistance = Math.Abs(ycenter - ypoint);
                bool isIntK = (Math.Pow(rcircle, 2) >= (Math.Pow(xdistance, 2) + Math.Pow(ydistance, 2)));

                //Проверка във правоъгълника

                double cornerX = -1;
                double cornerY = 1;
                double width = 6;
                double height = 2;

                bool isOutR = (xpoint >= cornerX && xpoint <= cornerX + width && ypoint >= cornerY -height && ypoint <= cornerY);
                Console.WriteLine(isIntK==true && isOutR==false);
                //Console.WriteLine(isOutR); Console.WriteLine(isIntK);
                //Console.WriteLine(xpoint <= cornerX || xpoint >= cornerX + width);
                //Console.WriteLine(ypoint <= cornerY - height || ypoint >= cornerY);
                Console.WriteLine("If you wish to repeat press y ");
                run = Console.ReadLine();
            }
        }
    }
}
