using System;
using System.Numerics;


namespace _7.Calculate_3_
{
    class Program
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger calculate1 = 1;
            BigInteger calculate2 = 1;
            for (BigInteger i = k + 1; i <= n; i++)
            {
                calculate1 *= i;
            }

            for (BigInteger j = n-k; j>1;j--)
            {
                calculate2 *= j;
            }
            Console.WriteLine(calculate1/calculate2);
        }
    }
}
