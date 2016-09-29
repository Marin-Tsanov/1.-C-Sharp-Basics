using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = ((Math.Pow(b, 2)) - (4 *( a * c)));

            if (d<0)
            {
                string norealroots = "no real roots";
                Console.WriteLine(norealroots);
            }

            else if (d==0)
            {
                double x = ((-b) / (2 * a));
                Console.WriteLine("{0:F2}",x); 
            }

            else
            {
                double x1 = (((-b) + (Math.Sqrt(d))) / (2 * a));
                double x2 = (((-b) - (Math.Sqrt(d))) / (2 * a));
                double y1 = Math.Min(x1,x2);
                double y2 = Math.Max(x1, x2);
                Console.WriteLine("{0:F2}",y1);
                Console.WriteLine("{0:F2}", y2);
            }
        }
    }
}
