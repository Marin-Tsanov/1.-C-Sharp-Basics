using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            ushort a = ushort.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(a, 2));
        }
    }
}
