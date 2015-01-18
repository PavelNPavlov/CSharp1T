/*Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/
using System;

public struct BankAcc
{
    //Декларация на променливите във структурата. Ключовата дума public не променя нищо само дава достъп до данните във обекта;
    public string firstn;
    public string middlen;
    public string lastn;
    public decimal balance;
    public string bankName;
    public string IBAN;
    public string crediCard1; //Избрал съм string въпреки че са само цифри, но с тях няма да се извършват математически опреции
    public string crediCard2;
    public string crediCard3;

    public BankAcc(string fn,string mn, string ln,decimal b,string bN,string iban,string cc1,string cc2,string cc3)
    {
        firstn = fn;
        middlen = mn;
        lastn = ln;
        balance = b;
        bankName = bN;
        IBAN = iban;
        crediCard1 = cc1;
        crediCard2 = cc2;
        crediCard3 = cc3;
    }//Конструктор създава обеката според въведените данни. Приписва данните според въвденото

} //Структира която обединява данните във един обек. Предимството е че данните се комплектовани

namespace Problem_11
{
    class Program
    {
        static void Main()
        {
            BankAcc me1 = new BankAcc("Pavel","Naskov","Pavlov",1000.00m,"CoolestBank","IBANXXXXXX","xxxx xxxx xxxx xxxx xxxx","xxxx xxxx xxxx xxxx xxxx","xxxx xxxx xxxx xxxx xxxx");//създавне на обеката
            Console.WriteLine(me1.firstn);
            Console.WriteLine(me1.middlen);
            Console.WriteLine(me1.lastn);
            Console.WriteLine(me1.balance+ " billion dolars" );
            Console.WriteLine(me1.bankName);
            Console.WriteLine(me1.IBAN);
            Console.WriteLine(me1.crediCard3); //извикване на данните подобно на DateTime.Now

        }
    }
}
//Декларации ако нямаше структура
/*  string firstn;
    string middlen;
    string lastn;
    decimal balance;
    string bankName;
    string IBAN;
    string crediCard1; //Избрал съм string въпреки че са само цифри, но с тях няма да се извършват математически опреции
    string crediCard2;
    string crediCard3;
 */