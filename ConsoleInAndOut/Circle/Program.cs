using System;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * (Math.PI * r);
            double area = (Math.Pow(r, 2)) * Math.PI;
            Console.Write("{0:F2} {1:F2}",perimeter,area);
        }
    }
}
