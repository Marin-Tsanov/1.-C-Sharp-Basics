using System;
using System.Numerics;


namespace _15.GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            String[] substrings = value.Split(' ');

            int[] GCD = Array.ConvertAll(substrings, int.Parse);

            int a = Math.Max(GCD[0], GCD[1]);
            int b = Math.Min(GCD[0], GCD[1]);

            int a1 = a;
            int b1 = b;

            int c1 = 1;

            do
            {
                c1=a1 % b1;
                a1 = b1;
                b1 = c1;
            }
            while (c1!=0);

            Console.WriteLine(a1);
        }
    }
}
