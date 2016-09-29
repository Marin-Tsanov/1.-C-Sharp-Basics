using System;

namespace Biggestof3
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double[] third = { a, b, c, d, e };

            double max_value = -200;
            for (int i = 0; i < third.Length; i++)
            {
                if (third[i] > max_value)
                    max_value = third[i];
            }

            Console.WriteLine(max_value);
        }
    }
}
