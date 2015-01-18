/*Problem 4. Unicode Character

Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be 
 */
using System;
using System.Text;

namespace Problem_04
{
    class Program
    {
        static void Main()
        {
            string symbol="\u00A2";
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(symbol); // За да излезе правилно от properties на конзолата се избира Consolas font
            
        }
    }
}
