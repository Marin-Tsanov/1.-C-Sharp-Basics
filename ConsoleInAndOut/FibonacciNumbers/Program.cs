using System;
namespace FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x1 = 0;
            double x2 = 1;

            if ((n == 1)&(n<2))
            {
                Console.Write(x1);
            }
            else if (n == 2)
            {
                Console.Write(x1 + ", "+x2);
            }
            
            else
            {
                if (n > 2)
                {
                    Console.Write(x1 + ", " + x2);

                    for (int i = 3; i <= n; i++)
                    {
                        double x3 = x2 + x1;
                        Console.Write(", "+x3);
                        x1 = x3 - x1;
                        x2 = x3 - 0;
                    }
                }
            }
        }
    }
}
