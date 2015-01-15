using System;

public struct Empl
{
   public string firstn;
   public string lastn;
   public int age;
   public char gender;
   public int idnum;
   public int unique;
    
    public Empl (string fn,string ln,int a,char g,int id, int num)  
    {
        firstn=fn;
        lastn=ln;
        age = a;
        gender = g;
        idnum = id;
        unique = num;        
    }

}

namespace _3_10_Employee_Data

 {   
    class Program
    {
        static void Main()
        {
            Empl me1 = new Empl("Pavel ", "Pavlov ", 23, 'm', 12223, 1231);
            Console.WriteLine(me1.firstn + me1.lastn + me1.age + me1.gender);

        }
    }
}
