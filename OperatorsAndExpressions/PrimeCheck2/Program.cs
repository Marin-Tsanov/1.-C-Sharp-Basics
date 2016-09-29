using System;


namespace PrimeCheck2
{
    class Program
    {
        static void Main()
        {
            int theNum = int.Parse(Console.ReadLine());
            if (theNum < 2)
            {
                Console.WriteLine("false");
            }

            else if (theNum == 2)
                {
                Console.WriteLine("true");
                }
            else
            {
                int a;
                for (a = 3; theNum % a != 0; a += 2) ;
                if (a == theNum)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }
        }

    }
}

