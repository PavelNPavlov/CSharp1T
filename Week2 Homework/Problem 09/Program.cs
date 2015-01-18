/*Problem 9. Exchange Variable Values

Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.*/
using System;


namespace Problem_09
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("a={0} and b={1}", a, b);
            int temp;

            temp = b; // Запазване на едната променлива във временна променлива, сменяме стойноста и и след това използваме информацията от temp за другата
            b = a;
            a = temp;

            Console.WriteLine("After Swap\na={0} and b={1}", a, b);

        }
    }
}
