using System;
using System.Numerics;

namespace _1.Task_1_Mutant_Squirrels
{
    class Program
    {
        static void Main()
        {
            double t = ulong.Parse(Console.ReadLine());
            double b = ulong.Parse(Console.ReadLine());
            double s = ulong.Parse(Console.ReadLine());
            double n = ulong.Parse(Console.ReadLine());

            double tails = t * b * s * n;

            double calctails = tails % 2;
            double bosstails;

            if (calctails == 0)
            {
                bosstails = tails * 376439;

                Console.WriteLine("{0:F3}", bosstails);
            }

            else
            {
                bosstails = tails / 7;
                Console.WriteLine("{0:F3}", bosstails);
            }
        }
    }
}

