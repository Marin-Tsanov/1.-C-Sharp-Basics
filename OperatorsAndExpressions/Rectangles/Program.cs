using System;

namespace Rectangles
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = (width * height);
            double perimeter = 2 * (width + height);
            string s = string.Format("{0:F2}" + " " + "{1:F2}", area, perimeter);
            Console.WriteLine(s);
        }
    }
}

