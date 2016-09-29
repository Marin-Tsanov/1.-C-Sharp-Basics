using System;

namespace DivideBy7And5
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int b = number % 35;
           
            Console.WriteLine(b==0 ? "true "+number : "false " + number);
        }
    }
}
