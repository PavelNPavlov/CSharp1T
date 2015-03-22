using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlAdress = Console.ReadLine();
            string fileName = Console.ReadLine();
            try
            {
                File.Create(fileName);
                WebClient myWeb = new WebClient();

                myWeb.DownloadFile(urlAdress, fileName);
            }
            
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("Access to location not allowed");
            }
            catch(NotSupportedException)
            {
                Console.WriteLine("File Format not supproted");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("No file Name or ulr adress");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("String is not a valid file name");
            }

            catch(System.IO.PathTooLongException)
            {
                Console.WriteLine("File Path too long");
            }

            catch(System.Net.WebException)
            {
                Console.WriteLine("No internet acess");
            }

            
        }
    }
}
