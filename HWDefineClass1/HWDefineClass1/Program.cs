using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWDefineClass1
{
    class Program
    {
        static void Main(string[] args)
        {

            GSM[] inventory = new GSM[]
            {
                new GSM("Samung", "Galaxy"),
                new GSM("Galaxy","Samsung",200),
                new GSM("Galaxy","Samsung",200,new Display(new Size(20,10),12000))
            };

            foreach (var item in inventory)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(GSM.iphone4S);

            GSM testCallHistory = GSM.iphone4S;

            testCallHistory.CallHistory.Add(new Call(DateTime.Now, "0885369852", 50));
            testCallHistory.CallHistory.Add(new Call(DateTime.Now, "0885369852", 50));
            testCallHistory.CallHistory.Add(new Call(DateTime.Now, "0885369852", 50));
            testCallHistory.CallHistory.Add(new Call(DateTime.Now, "0000000000", 100));

            foreach (var item in testCallHistory.CallHistory)
            {
                Console.WriteLine(item);
                
            }
            
            var item1 = testCallHistory.CallHistory.Max(x => x.Duration);

            //testCallHistory.Delete(testCallHistory.CallHistory.Find(o=> o.Duration==item1)); 
            testCallHistory.Remove(o => o.Duration == item1); //similar to delete but instead of taking a Call as argument it takes a function
            Console.WriteLine();
            foreach (var item in testCallHistory.CallHistory)
            {
                Console.WriteLine(item);
                
            }

            Console.WriteLine(testCallHistory.TotalCost(0.37m));
            
            Console.WriteLine();
        }
    }
}
