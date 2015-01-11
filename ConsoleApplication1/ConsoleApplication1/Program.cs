using System;
class Age10
{
    static void Main()
    {
        //Input Section
        Console.WriteLine("Input year of birth: ");

        int n; // For input format check
        string z = Console.ReadLine(); //read input
        //input format check
        while (String.IsNullOrEmpty(z) == true || int.TryParse(z, out n) == false)
        {
            z = Console.ReadLine();
        }

        int yearb = int.Parse(z);

        //Data sensibility check
        while (yearb < 1890 || yearb > 2015)
        {
            Console.WriteLine("Impossible year of birth! Please try again! ");
            z = Console.ReadLine();
            while (String.IsNullOrEmpty(z) == true || int.TryParse(z, out n) == false)
            {
                z = Console.ReadLine();
            }//format check
            yearb = int.Parse(z);
        }


        Console.WriteLine("Input month of birth: ");
        z = Console.ReadLine();
        while (String.IsNullOrEmpty(z) == true || int.TryParse(z, out n) == false)
        {
            z = Console.ReadLine();
        }
        int monthb = int.Parse(z);

        while (monthb < 0 || monthb > 12)
        {
            Console.WriteLine("Impossible month of birth! Please try again! ");
            z = Console.ReadLine();
            while (String.IsNullOrEmpty(z) == true || int.TryParse(z, out n) == false)
            {
                z = Console.ReadLine();
            }
            monthb = int.Parse(z);

        }


        Console.WriteLine("Input day of birth: ");
        z = Console.ReadLine();
        while (String.IsNullOrEmpty(z) == true || int.TryParse(z, out n) == false)
        {
            z = Console.ReadLine();
        }
        int dayb = int.Parse(z);

        while (dayb < 0 || dayb > 31 || (yearb % 4 != 0 && monthb == 2 && dayb > 28) || (yearb % 4 == 0 && monthb == 2 && dayb > 29))
        {
            Console.WriteLine("Impossible day of birth! Please try again! ");
            z = Console.ReadLine();
            while (String.IsNullOrEmpty(z) == true || int.TryParse(z, out n) == false)
            {
                z = Console.ReadLine();
            }
            dayb = int.Parse(z);

        }
        //Program section no if statements
        DateTime dateb = new DateTime(yearb, monthb, dayb);

        Console.WriteLine(dateb);
        DateTime datenow = DateTime.Now; //Not needed

        TimeSpan Period = datenow.Subtract(dateb); //Gives a period, in days most usfull

        double y = Math.Truncate(Period.TotalDays / 365.25); //Get Years
        double d = Math.Truncate(Period.TotalDays - y * 365.25); //Get Days

        Console.WriteLine("Now you are " + y + "years and " + d + " days old!");
        Console.WriteLine("In ten years you are " + (y + 10) + "years and " + d + " days old!");

        //Version2 Programs If structures used
        /*
                int age;
                Console.WriteLine(" You are born on:" +dayofbirth+"/"+monthofbirht+"/"+ yearofbirht+"\n");
                if (monthofbirht < DateTime.Now.Month)
                {
                    if (dayofbirth < DateTime.Now.Day)
                    {
                        age = DateTime.Now.Year - yearofbirht;
                    }
                    else
                    {
                        age = DateTime.Now.Year - yearofbirht -1;
                    }
                }
                else
                {
                    age = DateTime.Now.Year - yearofbirht - 1;
                }
                Console.WriteLine("Your age is:" + age + "years old" );
                int age10 = age + 10;
                Console.WriteLine("age10);
                DateTime.  
         */



    }
}

