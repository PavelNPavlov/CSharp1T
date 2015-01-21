/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

using System;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            Start:
            try
            {
                Input:
                Console.Write("Company name: ");
                string companyName = Console.ReadLine();
                Console.Write("Company address: ");
                string companyAddress = Console.ReadLine();
                Console.Write("Phone number: ");
                string companyPhone = Console.ReadLine();
                Console.Write("Fax number: ");
                string companyFax = Console.ReadLine();
                Console.Write("Email: ");
                string companyEmail = Console.ReadLine();
                Console.Write("Manager first name: ");
                string managerFirstName = Console.ReadLine();
                Console.Write("Manager Last name: ");
                string managerLastName = Console.ReadLine();
                Console.Write("Manager Age: ");
                int managerAge = int.Parse(Console.ReadLine());
                Console.Write("Manager first name: ");
                string managerPhone = Console.ReadLine();

            Output:
                Console.WriteLine("\n\n\n");
                Console.WriteLine(companyName);
                Console.WriteLine(companyAddress);
                Console.WriteLine(companyPhone);
                Console.WriteLine(companyEmail);
                Console.WriteLine(managerFirstName);
                Console.WriteLine(managerLastName);
                Console.WriteLine(managerAge);
                Console.WriteLine(managerPhone);
            }

            catch(FormatException)
            {
                Console.WriteLine("Invalide format");
                goto Start;
            }

            Console.WriteLine("If you wish to run the program again press y");
            if (Console.ReadLine() == "y") { goto Start; }

        }
    }
}
