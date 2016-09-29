using System;

namespace XXXXXX
{
    class Program
    {
        static void Main()
        {
            double x =double.Parse(Console.ReadLine()) ;
            double y = double.Parse(Console.ReadLine());

            double z = (x * x) + (y * y);
            double r = 2 * 2;

            if (z<=r)
            {
                Console.WriteLine("yes {0:F2}",Math.Sqrt(z));
            }

            else
            {
                Console.WriteLine("no {0:F2}",Math.Sqrt(z));
            }
            
        }
    }
}
