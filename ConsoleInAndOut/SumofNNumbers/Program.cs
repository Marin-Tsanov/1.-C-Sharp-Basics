using System;

namespace SumofNNumbers
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            for ( int i=1; i<= n;i++)
            {
                double a = double.Parse(Console.ReadLine());
                sum  += a;
            }
            Console.WriteLine(sum);
        }
    }
}
