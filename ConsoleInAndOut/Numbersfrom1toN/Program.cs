using System;

namespace Numbersfrom1toN
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for ( int i=1;i<= n;i++)
            {
                int a = n - (n - i);
                Console.WriteLine(a);
            }
        }
    }
}
