using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = null;
            filepath=Console.ReadLine();
            try
            {
                string text = System.IO.File.ReadAllText(filepath);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Not valid paf");
            }

            catch(System.IO.PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }

            catch(System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found");
            }

            catch(System.UnauthorizedAccessException)
            {
                Console.WriteLine("You dont have access");
            }

            catch(System.NotSupportedException)
            {
                Console.WriteLine("File format is not supported.");
            }
            catch(System.Security.SecurityException)
            {
                Console.WriteLine("File protected by password");
            }

            
        }
    }
}
