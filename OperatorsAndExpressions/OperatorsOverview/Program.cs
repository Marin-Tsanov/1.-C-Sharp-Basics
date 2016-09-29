using System;

namespace OperatorsOverview
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 2)
            {
                Console.WriteLine("false");
            }
            else if (number == 2)
            {
                Console.WriteLine("true");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                int i;
                for (i = 3; number % i != 0; i += 2)
                {
                    if (number ==i)
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
}


