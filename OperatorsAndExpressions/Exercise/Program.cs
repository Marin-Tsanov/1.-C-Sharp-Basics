using System;

namespace Exercise
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            if (v==0)
            {
                int a = 1 << p;
                long mask = (n & ~a);
                Console.WriteLine(mask);
            }
            else if (v==1)
            {
                int b = 1 << p;
                long maskN = (n | b);
                Console.WriteLine(maskN);
            }
        }
    }
}
 