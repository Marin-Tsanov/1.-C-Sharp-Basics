using System;
using System.Numerics;


namespace _7.Calculate_3_
{
    class Program
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger calculate1 = 1;
            BigInteger calculate2 = 1;
            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                {
                }

                for (BigInteger i = n + 2; i <= 2 * n; i++)
                {
                    calculate1 *= i;
                }

                for (BigInteger j = 1; j <= n; j++)
                {
                    calculate2 *= j;
                }
                Console.WriteLine(calculate1 / calculate2);
            }
        }
    }
}