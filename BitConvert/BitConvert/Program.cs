using System;


namespace BitConvert
{
    class Program
    {
        static void Main()
        {
            /*int number = 5;
            string bitvalue = Convert.ToString(number, 2); //convert
            string bitnumber = bitvalue.PadLeft(32, '0'); //add zeros for full representation of int
            int numberconverted = Convert.ToInt32(bitnumber, 2); //back convert
            Console.WriteLine(bitnumber);
            Console.WriteLine(bitnumber.Length);
            Console.WriteLine(bitvalue.Length);*/

            int n = 5;
            int result;

            result = n & 4;
            Console.WriteLine(result);

        }
    }
}
