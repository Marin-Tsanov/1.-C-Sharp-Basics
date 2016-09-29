using System;
using System.Numerics;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main()
        {
            BigInteger binary = BigInteger.Parse(Console.ReadLine());
            int length = binary.ToString().Length;

            BigInteger [] deck = new BigInteger[length];

            for (int i = 0; i < length; i++)
            {
                deck[i] = binary % 10;
                binary = binary / 10;
            }

            double decima = 0;
            for (int i = 0; i < length; i++)
            {
                if (deck[i] == 1)
                {
                    decima += (Math.Pow(2, i));
                }
            }
            Console.WriteLine(decima);
        }
    }
}
