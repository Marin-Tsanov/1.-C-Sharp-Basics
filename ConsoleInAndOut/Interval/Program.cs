using System;

namespace Interval
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int a = m - n;
            int d = 0;

            for (int i = 1; i < a; i++)
            {
                int b = (n + i);
                int c = b % 5;
                if (c == 0)
                {
                    d += 1;
                }
            }
            Console.WriteLine(d);
        }
    }
}
