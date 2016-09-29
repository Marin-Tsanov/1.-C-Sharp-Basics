using System;

namespace Sumof3numbers
{
    class Program
    {
        static void Main()
        {
            int n = 3;
            double sum = 0;
            for ( int i=1;i<=n;i++)
            {
                double a = double.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine(sum);
        }
    }
}
