using System;

namespace _5.Calculate
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double product = 1;
            double sum = 1;
            for (int i=1;i<=n;i++)
            {
                double number = (i/x);
                product *= number;
                sum += product;
            }
            Console.WriteLine("{0:F5}",sum);

        }
    }
}
