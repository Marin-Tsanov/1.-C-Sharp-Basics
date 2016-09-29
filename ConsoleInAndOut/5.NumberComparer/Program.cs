using System;

namespace _5.NumberComparer
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = Math.Max(a, b);
            Console.WriteLine(c);
        }
    }
}
