using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = (a % 2);
            Console.WriteLine(b == 0 ? "even " + a : "odd " + a);
        }
    }
}
