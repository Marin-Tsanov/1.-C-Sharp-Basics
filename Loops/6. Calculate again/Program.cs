using System;
using System.Numerics;

namespace _6.Calculate_again
{
    class Program
    {
        static void Main()
        {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger x = BigInteger.Parse(Console.ReadLine());
        BigInteger calculate = 1;

            for (BigInteger i =x+1; i<=n; i++)
            {
                    calculate*= i;
            }
            Console.WriteLine(calculate);
        }
    }
}
