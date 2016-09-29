using System;



class PrintNumbers
{
    static void Main()
    {
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;
        int age = today.Year - birthdate.Year;
        int ageLater = age + 10;
        Console.WriteLine(age);
        Console.WriteLine(ageLater);

        if (today.Month > birthdate.Month)
        {
            if (age >= 1)
            {
                Console.WriteLine(age - 1);
            }

        }
        else if (today.Day > birthdate.Day)
        {
            if (age >= 1)
            {
                Console.WriteLine(age - 1);
            }

        }

    }
}

