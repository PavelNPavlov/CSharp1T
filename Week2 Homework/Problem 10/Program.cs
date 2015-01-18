/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.*/

using System;

public struct Empl
{
    //Декларация на променливите във структурата. Ключовата дума public не променя нищо само дава достъп до данните във обекта;
    public string firstn;
    public string lastn;
    public int age;
    public char gender;
    public int idnum;
    public int uniquenumber;

    public Empl(string fn, string ln, int a, char g, int id, int num)
    {
        firstn = fn;
        lastn = ln;
        age = a;
        gender = g;
        idnum = id;
        uniquenumber = num;
    }//Конструктор създава обеката според въведените данни. Приписва данните според въвденото

} //Структира която обединява данните във един обек. Предимството е че данните се комплектовани

namespace Problem_10
{
    class Program
    {
        static void Main()
        {
            Empl me1 = new Empl("Pavel ", "Pavlov ", 23, 'm', 12223, 1231);//създавне на обеката
            Console.WriteLine(me1.firstn + me1.lastn + me1.age + me1.gender); //извикване на данните подобно на DateTime.Now

        }
    }
}

/*Версия без структура. (за да се тества просто сложете горния код във коментар кактое направено със този
namespace Problem_10
{
    class Program
    {
        static void Main()
        {
            
            string firstn="Pavel";
            string lastn="Pavlov";
            int age = 23;
            char gender='m';
            int idnum=12223;
            int uniquenumber=23548;

            Console.WriteLine(firstn);
            Console.WriteLine(lastn);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(idnum);
            Console.WriteLine(uniquenumber);


        }
    }
}*/
