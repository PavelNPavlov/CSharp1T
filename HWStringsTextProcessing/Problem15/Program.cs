//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.
//Example:

//input	output
//C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseSentence
{
    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(TagReformat(input));
    }

    static string TagReformat(string s)
    {
        string output = s;

        output=output.Replace(@"<a href=""","[URL=");
        output = output.Replace(@""">", "]");
        output = output.Replace(@"</a>", @"[/URL]");

        return output;

    }
}