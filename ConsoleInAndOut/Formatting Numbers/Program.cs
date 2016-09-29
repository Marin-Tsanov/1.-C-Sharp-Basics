using System;

namespace Formatting_Numbers
{
    class Program
    {
        static void Main()
        {


            int a = int.Parse(Console.ReadLine());
            string hexadecimal = a.ToString("X");
            
            string binary = Convert.ToString(a,2).PadLeft(10,'0');

            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            
            Console.Write("{0,-10}", hexadecimal);
            Console.Write("|{0,10}|",binary);
            Console.Write("{0,10:F2}", b);
            Console.Write("|{0,-10:F3}|",c);

        }
    }
}
