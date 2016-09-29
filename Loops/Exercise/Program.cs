using System;
using System.Numerics;

namespace Exercise
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if ((n > 1) && (n < m))
            {
                for (int num = n; num <= m; num++)
                {
                    bool prime = true;
                    int divider = 2;
                    double maxDivider = Math.Sqrt(num);

                    while (divider <= maxDivider)
                    {
                        if (num % divider == 0)
                        {
                            prime = false;
                            break;
                        }
                        divider++;
                    }
                    if (prime)
                    {
                        Console.WriteLine("{0}", num);
                    }
                }

            }
            else
            {
                Console.WriteLine(" Invalid number entered. ");
            }
        }
    }
}
